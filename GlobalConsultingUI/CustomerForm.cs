using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GlobalConsultingUI.Validation;

namespace GlobalConsultingUI
{
    public partial class CustomerForm : Form
    {
        private client_schedule _context = new client_schedule();
        private int _countryId;
        private int _cityId;
        private int _addressId;
        private int _customerId;
        private int _country;
        private int _city;
        private int _address;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            searchTextBox.Text = "";
            customerNameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            postalCodeTextBox.Text = "";
            countryTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.TextLength >= 4)
            {
                var customerInfo = _context.customers.Where(c => c.customerName == searchTextBox.Text)
                                                .Select(c => new //This lambda expression allows me to shorten the following lines of code and makes it much more readable than writing the complete sql statement out
                                                {
                                                    CustomerName = c.customerName,
                                                    Address = c.address.address1,
                                                    City = c.address.city.city1,
                                                    Postal = c.address.postalCode,
                                                    Country = c.address.city.country.country1,
                                                    Phone = c.address.phone,
                                                    CustomerId = c.customerId,
                                                    CountryId = c.address.city.country.countryId,
                                                    CityId = c.address.city.cityId,
                                                    AddressId = c.address.addressId
                                                }).FirstOrDefault();

                if (customerInfo != null)
                {
                    customerNameTextBox.Text = customerInfo.CustomerName;
                    addressTextBox.Text = customerInfo.Address;
                    cityTextBox.Text = customerInfo.City;
                    postalCodeTextBox.Text = customerInfo.Postal;
                    countryTextBox.Text = customerInfo.Country;
                    phoneTextBox.Text = customerInfo.Phone;
                    _countryId = customerInfo.CountryId;
                    _cityId = customerInfo.CityId;
                    _addressId = customerInfo.AddressId;
                    _customerId = customerInfo.CustomerId;
                }
            }
        }

        private DateTime ConvertUtc(DateTime date)
        {
            return TimeZoneInfo.ConvertTimeToUtc(date, TimeZoneInfo.Local);
        }

        private customer GetCustomerById()
        {
            return _context.customers.Find(_customerId);
        }

        private void RemoveAddress()
        {
            if (!_context.customers.Any(c => c.addressId == _addressId))
            {
                var rmvAddress = _context.addresses.Find(_addressId);
                _context.addresses.Remove(rmvAddress);

                _context.SaveChanges();
            }
        }

        private void RemoveCity()
        {
            if (!_context.addresses.Any(a => a.cityId == _cityId))
            {
                var rmvCity = _context.cities.Find(_cityId);
                _context.cities.Remove(rmvCity);

                _context.SaveChanges();
            }
        }

        private void RemoveCountry()
        {
            if (!_context.cities.Any(c => c.countryId == _countryId))
            {
                var rmvCountry = _context.countries.Find(_countryId);
                _context.countries.Remove(rmvCountry);

                _context.SaveChanges();
            }
        }

        private bool Validation(string customerName, string address, string city, string postalCode, string country, string phone)
        {
            if (!InputValidators.LetterValidator(customerName))
            {
                MessageBox.Show("Customer Name must not be empty and can only contain letters!");
                return false;
            }
            else if (!InputValidators.LetterNumberValidator(address))
            {
                MessageBox.Show("Address must not be empty and contain only letters and numbers!");
                return false;
            }
            else if (!InputValidators.LetterValidator(city))
            {
                MessageBox.Show("City must not be empty and can only contain letters!");
                return false;
            }
            else if (!InputValidators.NumberValidator(postalCode))
            {
                MessageBox.Show("Postal Code must not be empty and can only contain numbers!");
                return false;
            }
            else if (!InputValidators.LetterValidator(country))
            {
                MessageBox.Show("Country must not be empty and can only contain letters!");
                return false;
            }
            else if (!InputValidators.PhoneNumberValidator(phone))
            {
                MessageBox.Show("Phone Number must not be empty and must be in the format xxx-xxxx!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SubmitCustomerInfo()
        {
            if (_context.countries.Any(c => c.country1 == countryTextBox.Text))
            {
            _country = _context.countries.Where(c => c.country1 == countryTextBox.Text).Select(c => c.countryId).First();
            }
            else
            {
                var Country = new country()
                {
                    country1 = countryTextBox.Text,
                    createDate = ConvertUtc(DateTime.Now),
                    createdBy = LoginForm.User,
                    lastUpdate = ConvertUtc(DateTime.Now),
                    lastUpdateBy = LoginForm.User
                };

                _context.countries.Add(Country);

                _context.SaveChanges();

                _country = Country.countryId;
            }

            if (_context.cities.Any(c => c.city1 == cityTextBox.Text && c.countryId == _country))
            {
                _city = _context.cities.Where(c => c.city1 == cityTextBox.Text).Select(c => c.cityId).First();
            }
            else
            {
                var City = new city()
                {
                    city1 = cityTextBox.Text,
                    countryId = _country,
                    createDate = ConvertUtc(DateTime.Now),
                    createdBy = LoginForm.User,
                    lastUpdate = ConvertUtc(DateTime.Now),
                    lastUpdateBy = LoginForm.User
                };

                _context.cities.Add(City);

                _context.SaveChanges();

                _city = City.cityId;
            }

            if (_context.addresses.Any(a => a.address1 == addressTextBox.Text && a.cityId == _city && a.postalCode == postalCodeTextBox.Text && a.phone == phoneTextBox.Text))
            {
                _address = _context.addresses.Where(a => a.address1 == addressTextBox.Text && a.cityId == _city && a.postalCode == postalCodeTextBox.Text && a.phone == phoneTextBox.Text).Select(a => a.addressId).First();
            }
            else
            {
                var Address = new address()
                {
                    address1 = addressTextBox.Text,
                    address2 = "",
                    cityId = _city,
                    postalCode = postalCodeTextBox.Text,
                    phone = phoneTextBox.Text,
                    createDate = ConvertUtc(DateTime.Now),
                    createdBy = LoginForm.User,
                    lastUpdate = ConvertUtc(DateTime.Now),
                    lastUpdateBy = LoginForm.User
                };

                _context.addresses.Add(Address);

                _context.SaveChanges();

                _address = Address.addressId;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = Validation(customerNameTextBox.Text, addressTextBox.Text, cityTextBox.Text, postalCodeTextBox.Text, countryTextBox.Text, phoneTextBox.Text);

                if (validation)
                {
                    SubmitCustomerInfo();

                    if (_context.customers.Any(c => c.customerName == customerNameTextBox.Text))
                    {
                        MessageBox.Show("Customer already exists!");
                        return;
                    }
                    else
                    {
                        var Customer = new customer()
                        {
                            customerName = customerNameTextBox.Text,
                            addressId = _address,
                            active = true,
                            createDate = ConvertUtc(DateTime.Now),
                            createdBy = LoginForm.User,
                            lastUpdate = ConvertUtc(DateTime.Now),
                            lastUpdateBy = LoginForm.User
                        };

                        _context.customers.Add(Customer);

                        _context.SaveChanges();
                    }

                    ClearData();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = Validation(customerNameTextBox.Text, addressTextBox.Text, cityTextBox.Text, postalCodeTextBox.Text, countryTextBox.Text, phoneTextBox.Text);

                if (validation)
                {
                    SubmitCustomerInfo();

                    var confirmUpdate = MessageBox.Show("Are you sure you want to update this customer??",
                                            "Confirm Update!",
                                            MessageBoxButtons.YesNo);

                    if (confirmUpdate == DialogResult.Yes)
                    {
                        var updateCustomer = GetCustomerById();

                        if (updateCustomer.customerName == customerNameTextBox.Text && _country == _countryId &&
                            _city == _cityId && _addressId == _address)
                        {
                            MessageBox.Show("No information has been changed!");
                            return;
                        }
                        else
                        {
                            updateCustomer.customerName = customerNameTextBox.Text;
                            updateCustomer.addressId = _address;
                            updateCustomer.lastUpdateBy = LoginForm.User;
                            _context.SaveChanges();

                            if (_addressId != _address)
                            {
                                RemoveAddress();
                            }

                            if (_cityId != _city)
                            {
                                RemoveCity();
                            }

                            if (_countryId != _country)
                            {
                                RemoveCountry();
                            }

                            ClearData();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this customer??",
                                       "Confirm Delete!",
                                       MessageBoxButtons.YesNo);

                if (confirmDelete == DialogResult.Yes)
                {
                    if (_customerId != 0 && _customerId != null)
                    {
                        var rmvCustomer = GetCustomerById();
                        _context.customers.Remove(rmvCustomer);

                        _context.SaveChanges();

                        RemoveAddress();

                        RemoveCity();

                        RemoveCountry();

                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Please search for a valid customer!");
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DashboardForm();
            form.ShowDialog();
        }
    }
}