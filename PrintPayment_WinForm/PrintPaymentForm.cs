using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPayment_WinForm
{
    public partial class PrintPaymentForm : Form
    {

        ServiceReferencePrintPayment.IPrintPayment client = new ServiceReferencePrintPayment.PrintPaymentClient();

        public PrintPaymentForm()
        {
            try
            {
                InitializeComponent();

                ServiceReferencePrintPayment.ConversionTable conversionTable = client.GetConversionTable();

                if (conversionTable == null) return;

                pricePerSheetInput.Text = conversionTable.Price.ToString();
            } catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void getUserButton_Click(object sender, EventArgs e)
        {
            if (userInput.Text.Equals("")) return;

            ServiceReferencePrintPayment.User result = null;

            try
            {
                if (uidRadioButton.Checked)
                {
                    result = client.GetUserByUID(Convert.ToInt32(userInput.Text));
                }
                else if (usernameRadioButton.Checked)
                {
                    result = client.GetUserByUsername(userInput.Text);
                }

                if (result == null) {
                    MessageBox.Show($"User {userInput.Text} not found", "Error");
                    uidInputDisplay.Text = "";
                    usernameInputDisplay.Text = "";
                    creditInputDisplay.Text = "";
                    nbSheetsInputDisplay.Text = "";
                    return;
                }

                uidInputDisplay.Text = result.UID.ToString();
                usernameInputDisplay.Text = result.Username.ToString();
                creditInputDisplay.Text = result.Credit.ToString();
                nbSheetsInputDisplay.Text = result.NbSheets.ToString();
            } catch (FormatException formatException)
            {
                MessageBox.Show("UID must be an integer number", "Error");
            } catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }

        private void transferMoney_Click(object sender, EventArgs e)
        {

            try
            {
                if (uidRadioButton.Checked)
                { 
                    client.TransferMoneyByUID(Convert.ToInt32(userInput.Text), Convert.ToDecimal(moneyInput.Text));
                }
                else if (usernameRadioButton.Checked)
                {
                    client.TransferMoneyByUsername(userInput.Text, Convert.ToDecimal(moneyInput.Text));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void updatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                client.UpdatePrice(Convert.ToDecimal(pricePerSheetInput.Text));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
