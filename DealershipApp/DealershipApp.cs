using DealershipLibrary;
using System;
using System.Security.Cryptography.Xml;

namespace DealershipApp
{
    public partial class dealershipApp : Form
    {
        List<Dealership> dealerships = new List<Dealership>();
        BindingSource comboBoxBinding = new BindingSource();
        BindingSource carListBoxBinding = new BindingSource();
        BindingSource employeeListBoxBinding = new BindingSource();
        BindingSource financialsBinding = new BindingSource();

        public dealershipApp()
        {
            InitializeComponent(); //bla
            Data();
            //blabla

            //ComboBox Binding
            comboBoxBinding.DataSource = dealerships;
            dealershipComboBox.DataSource = comboBoxBinding;

            dealershipComboBox.DisplayMember = "ComboDisplay";
            if (dealerships != null) { dealershipComboBox.ValueMember = "ComboDisplay"; }

            //CarListBox Binding
            carListBoxBinding.DataSource = ((Dealership)dealershipComboBox.SelectedItem).Automobiles;
            carsListBox.DataSource = carListBoxBinding;

            carsListBox.DisplayMember = "ListBoxDisplay";
            if ((Dealership)dealershipComboBox.SelectedItem != null) { carsListBox.ValueMember = "ListBoxDisplay"; }

            //EmployeeListBox Binding
            employeeListBoxBinding.DataSource = ((Dealership)dealershipComboBox.SelectedItem).Employees;
            employeeListBox.DataSource = employeeListBoxBinding;

            employeeListBox.DisplayMember = "ListBoxDisplay";
            if ((Dealership)dealershipComboBox.SelectedItem != null) { employeeListBox.ValueMember = "ListBoxDisplay"; }

            //Financials Tab Binding
            financialsBinding.DataSource = ((Dealership)dealershipComboBox.SelectedItem).Employees;


        }


        private void Data()
        {
            //Sedans R US - index [0]
            dealerships.Add(new Dealership { Name = "Sedans R US" });
            dealerships[0].Automobiles.Add(new Sedan("Sedan", 5000, true, "Subaru", "blue", "Automatic", false, false));
            dealerships[0].Automobiles.Add(new Sedan("Sedan", 50000, false, "Subaru", "white", "Automatic", true, false));
            dealerships[0].Automobiles.Add(new Sedan("Sedan", 1000, false, "toyota", "white", "Automatic", false, false));
            dealerships[0].Automobiles.Add(new Truck("Truck", 63000, false, "Ford", "Purple", "Automatic", 6, "Crew", false, false));
            dealerships[0].Automobiles.Add(new Coupe("Coupe", 50000, false, "Acura", "black", "Manual", false));
            dealerships[0].Employees.Add(new Employees { ID = 1, Name = "Steve Jones", Commission = .2 });
            dealerships[0].Employees.Add(new Employees { ID = 2, Name = "Dave Williams" });
            dealerships[0].Employees.Add(new Employees { ID = 3, Name = "Brent Crystals" });
            dealerships[0].Employees.Add(new Employees { ID = 4, Name = "Tommy Buns" });
            dealerships[0].Employees.Add(new Employees { ID = 5, Name = "Shmo Joegan" });

            //Trucks 4 U - index [1]
            dealerships.Add(new Dealership { Name = "Trucks 4 U" });
            dealerships[1].Automobiles.Add(new Truck("Truck", 12000, true, "Chevy", "pink", "Manual", 5.5, "Crew", true, false));
            dealerships[1].Automobiles.Add(new Truck("Truck", 63000, false, "Ford", "Purple", "Automatic", 6, "Crew", false, false));
            dealerships[1].Automobiles.Add(new Truck("Truck", 63000, false, "Ford", "Purple", "Automatic", 6, "Crew", false, false));
            dealerships[1].Automobiles.Add(new Sedan("Sedan", 5000, true, "Subaru", "blue", "Automatic", false, false));
            dealerships[1].Automobiles.Add(new Coupe("Coupe", 50000, false, "Acura", "black", "Manual", false));
            dealerships[1].Employees.Add(new Employees { ID = 1, Name = "Dale Burnhardt", Commission = .2 });
            dealerships[1].Employees.Add(new Employees { ID = 2, Name = "Timmy two Thumbs" });
            dealerships[1].Employees.Add(new Employees { ID = 3, Name = "Bobo Lee" });
            dealerships[1].Employees.Add(new Employees { ID = 4, Name = "Ryder Mcguyver" });
            dealerships[1].Employees.Add(new Employees { ID = 5, Name = "Mudder" });

            //Coupele of kewl guys - index [1]
            dealerships.Add(new Dealership { Name = "Coupele of kewl guys" });
            dealerships[2].Automobiles.Add(new Coupe("Coupe", 50000, false, "Acura", "black", "Manual", false));
            dealerships[2].Automobiles.Add(new Coupe("Coupe", 22000, true, "Subaru", "blue", "Manual", true));
            dealerships[2].Automobiles.Add(new Coupe("Coupe", 2000, false, "Acura", "black", "Manual", false));
            dealerships[2].Automobiles.Add(new Truck("Truck", 63000, false, "Ford", "Purple", "Automatic", 6, "Crew", false, false));
            dealerships[2].Automobiles.Add(new Sedan("Sedan", 5000, true, "Subaru", "blue", "Automatic", false, false));
            dealerships[2].Employees.Add(new Employees { ID = 1, Name = "Erik Stephens", Commission = .2 });
            dealerships[2].Employees.Add(new Employees { ID = 2, Name = "Slick Back Tommy" });
            dealerships[2].Employees.Add(new Employees { ID = 3, Name = "Abercrombie and Bitch" });
            dealerships[2].Employees.Add(new Employees { ID = 4, Name = "Hue Jackedman" });
            dealerships[2].Employees.Add(new Employees { ID = 5, Name = "Steve Jones" });
        }

        private void dealershipComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeListBoxBinding.DataSource = ((Dealership)dealershipComboBox.SelectedItem).Employees;
            carListBoxBinding.DataSource = ((Dealership)dealershipComboBox.SelectedItem).Automobiles;
            employeeListBoxBinding.ResetBindings(false);
            carListBoxBinding.ResetBindings(false);
        }
    }
}