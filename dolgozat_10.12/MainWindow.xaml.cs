using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dolgozat_10._12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private bool isNameValid()
        {
            string Name = txtName.Text.Trim();
            if (Name == "")
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Name.Length < 3)
            {
                MessageBox.Show("A név mezőnek legalább 3 karakter hosszúnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private bool isAgeValid()
        {
            string AgeText = txtAge.Text.Trim();
            if (AgeText == "")
            {
                MessageBox.Show("Az életkor mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                int Age = int.Parse(AgeText);
                if (Age < 18 || Age > 100)
                {
                    MessageBox.Show("Az életkor mezőnek 18 és 100 közötti számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Az életkor mezőnek számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Az életkor mező túl nagy számot tartalmaz!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private bool isJogsiValid()
        {
            string JogsiText = txtJogsi.Text.Trim();
            if (JogsiText == "")
            {
                MessageBox.Show("A jogosítvány szám mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                int szam = int.Parse(JogsiText);
                if (szam < 6)
                {
                    MessageBox.Show("A jogosítvány számnak legalább 6 karakter hosszúnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A jogosítvány szám mezőnek számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("A jogosítvány szám mező túl nagy számot tartalmaz!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private bool isComboboxValid()
        {
            if (myComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Kérlek válaszd ki az autót!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private bool isberlesIdoValid()
        {
            string berlesIdo = txtBerlesIdo.Text.Trim();
            if (berlesIdo == "")
            {
                MessageBox.Show("A bérlési idő mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                int ido = int.Parse(berlesIdo);
                if (ido < 1 || ido > 30)
                {
                    MessageBox.Show("A bérlési időnek 1 és 30 közötti karaktert kell megadni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A bérlési idő mezőnek számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("A bérlési idő mező túl nagy számot tartalmaz!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        
        private int allExtras()
        {
            int alLExtra = 0;
            if (check1.IsChecked == true)
            {
                alLExtra += 1000;
            }
            if (check2.IsChecked == true)
            {
                alLExtra += 1500;
            }
            if (check3.IsChecked == true)
            {
                alLExtra += 2500;
            }
            return alLExtra;
        }
        private int ExtraTicket()
        {
            int ExtraTicket = 0;
            if (check4.IsChecked == true)
            {
                ExtraTicket += 2500;
            }
            return ExtraTicket;
        }
        
        private bool isProvValid()
        {
            if (rbCash.IsChecked == true || rbCard.IsChecked == true)
            {
                return true;
            }
            MessageBox.Show("Kérlek válaszd ki a fizetési módót!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
        private bool isAccepted()
        {
            if (checkAll.IsChecked == true)
            {
                return true;
            }
            MessageBox.Show("Kérlek fogadd el a bérlési feltételeket!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        private int carC()
        {
            int allCar = 0;
            if (myComboBox.SelectedIndex == 0)
            {
                allCar += 12000;
            }
            if (myComboBox.SelectedIndex == 1)
            {
                allCar += 18000;
            }
            if (myComboBox.SelectedIndex == 2)
            {
                allCar += 30000;
            }
            if (myComboBox.SelectedIndex == 3)
            {
                allCar += 35000;
            }
            return allCar;
        }
        private int prov()
        {
            int allProv = 0;
            if (rbA.IsChecked == true)
            {
                allProv += 0;
            }
            if (rbEx.IsChecked == true)
            {
                allProv += 3000;
            }
            if (rbAll.IsChecked == true)
            {
                allProv += 6000;
            }
            return allProv;
        }
        string typeCar()
        {
            string carType = "";
            if (myComboBox.SelectedIndex == 0)
            {
                carType = "Suzuki Swift";
            }
            if (myComboBox.SelectedIndex == 1)
            {
                carType = "Toyota Corolla";
            }
            if (myComboBox.SelectedIndex == 2)
            {
                carType = "BMW 3";
            }
            if (myComboBox.SelectedIndex == 3)
            {
                carType = "Tesla Model 3";
            }
            return carType;
        }
        string provType()
        {
            string provType = "";
            if (rbA.IsChecked == true)
            {
                provType = "Alap biztosítás";
            }
            if (rbEx.IsChecked == true)
            {
                provType = "Extra biztosítás";
            }
            if (rbAll.IsChecked == true)
            {
                provType = "Teljes biztosítás";
            }
            return provType;
        }
        string pay()
        {
            string payType =" ";
            if (rbCash.IsChecked == true)
            {
                payType = "Készpénz";
            }
            if (rbCard.IsChecked == true)
            {
                payType = "Bankkártya";
            }
            return payType;
        }
        string extarsFinal()
        {
            string extraf = "";
            if (check1.IsChecked == true)
            {
                extraf += "GPS";
            }
            if (check2.IsChecked == true)
            {
                extraf += ",Gyerekülés";
            }
            if (check3.IsChecked == true) 
            {
                extraf += ",Extra sofőr";
            }
            if (check4.IsChecked == true) 
            {
                extraf += ",Autópálya matrica";
            }
            return extraf;
        }
        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (!isNameValid()) return;
            if (!isAgeValid()) return;
            if (!isJogsiValid()) return;
            if (!isComboboxValid()) return;
            if (!isberlesIdoValid()) return;
            if (!isProvValid()) return;
            if (!isAccepted()) return;

            int Extras= allExtras();
            int CarPrice = carC();
            int ProvPrice = prov();
            int ExtraTicketPrice = ExtraTicket();
            int days = int.Parse(txtBerlesIdo.Text.Trim());
            string carType =typeCar();
            string provtype = provType();
            string paymentType = pay();
            string extrasF = extarsFinal();

            int TotalPrice= (CarPrice*days)+(ProvPrice*days)+(Extras*days) + ExtraTicketPrice;

            MessageBox.Show($"Sikeres autóbérlés!\n Ügyfél: {txtName} \n Autó:{carType} \n Időtartam:{days} nap \n Biztosítás:{provtype} \n Extrák: {extrasF} \n Fizetés:{paymentType} \n Fizetendő: {TotalPrice}Ft ", "Vásárlás összegzése", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}