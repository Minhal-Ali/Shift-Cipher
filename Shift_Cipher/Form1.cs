using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Cipher
{
    public partial class ShiftCipher : Form
    {
        public ShiftCipher()
        {
            InitializeComponent();
            encryptTechComboBox.Items.Add("Shift Cipher");
            encryptTechComboBox.Items.Add("Vigenere Cipher");
            Vigenere.initializeAlphabeticMatrix();
            Vigenere.initializeAlphabeticArray();
        }

        private void encryptMsgTextBtn_Click(object sender, EventArgs e)
        {
            if (encryptTechComboBox.Text == "Shift Cipher")
                encryptAccordingToShiftCipher(true);
            else if (encryptTechComboBox.Text == "Vigenere Cipher")
                encryptAccordingToVigenereCipher(true);
            else
                MessageBox.Show("Please Select The Technique First");
        }

        private void MsgClerBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }

        private void encryptTextClearBtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = null;
        }

        private void encryptAccordingToShiftCipher(bool isEncrypt)
        {
            richTextBox2.Text = Shift.manipulateMessage(richTextBox1.Text, Convert.ToInt32(numericUpDown1.Value),isEncrypt);
            richTextBox1.Text = null;
        }

        private void decryptMsgBtn_Click(object sender, EventArgs e)
        {
            if (encryptTechComboBox.Text == "Shift Cipher")
                decryptAccordingToShiftCipher(false);
            else if (encryptTechComboBox.Text == "Vigenere Cipher")
                decryptAccordingToVigenereCipher(false);
            else
                MessageBox.Show("Please Select The Technique First");
        }

        private void decryptAccordingToShiftCipher(bool isEncrypt)
        {
            richTextBox1.Text = Shift.manipulateMessage(richTextBox2.Text, Convert.ToInt32(numericUpDown1.Value), isEncrypt);
            richTextBox2.Text = null;
        }

        private void encryptAccordingToVigenereCipher(bool isEncrypt)
        {
            if ("Please Insert the key" == Vigenere.manipulateMessage(richTextBox1.Text, keyTxtBox.Text, isEncrypt))
                keyTxtBox.Text = Vigenere.manipulateMessage(richTextBox1.Text, keyTxtBox.Text, isEncrypt);
            else
                richTextBox2.Text = Vigenere.manipulateMessage(richTextBox1.Text, keyTxtBox.Text, isEncrypt);
            richTextBox1.Text = null;
        }

        private void decryptAccordingToVigenereCipher(bool isEncrypt)
        {
            if ("Please Insert the key" == Vigenere.manipulateMessage(richTextBox2.Text, keyTxtBox.Text, isEncrypt))
                keyTxtBox.Text = Vigenere.manipulateMessage(richTextBox2.Text, keyTxtBox.Text, isEncrypt);
            else
                richTextBox1.Text = Vigenere.manipulateMessage(richTextBox2.Text, keyTxtBox.Text, isEncrypt);
            richTextBox2.Text = null;
        }
    }
}
