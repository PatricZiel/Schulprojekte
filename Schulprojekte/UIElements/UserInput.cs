using Schulprojekte.Objekte;
using Schulprojekte.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulprojekte.UIElements
{
    public partial class UserInput : UserControl
    {
        public String userInputName = "";

        Label lbl_errorMessage;
        Panel inputBottomPanel;
        Label lbl_name;
        public Control input_field;

        String defaultValue = null;
        Boolean validationSuccess = false;

        EventHandler inputAfterValidatoinFailed;

        public UserInput()
        {
            InitializeComponent();
            InitializeInput();
        }
        public UserInput(String nameFragment, String label, String typeContant)
        {
            InitializeComponent();
            InitializeInput();

            userInputName = nameFragment;

            initializeErrorMessage("lbl_" + nameFragment + "Error", "Bitte gib " + label + " an");
            initializeLabel("lbl_" + nameFragment, label);
            initializeInputField("input_" + nameFragment, typeContant);
        }
        public UserInput(String nameFragment, String label, String typeContant, String defaultContent)
        {
            InitializeComponent();
            InitializeInput();

            userInputName = nameFragment;
            defaultValue = defaultContent;

            initializeErrorMessage("lbl_" + nameFragment + "Error", "Bitte gib " + label + " an");
            initializeLabel("lbl_" + nameFragment, label);
            initializeInputField("input_" + nameFragment, typeContant);
        }

        public void InitializeInput()
        {
            inputBottomPanel = new Panel();
            inputBottomPanel.Dock = DockStyle.Bottom;
            inputBottomPanel.Height = 32;
            Controls.Add(inputBottomPanel);
        }

        public void initializeErrorMessage(String name, String text)
        {
            lbl_errorMessage = new Label();

            lbl_errorMessage.Dock = DockStyle.Top;
            lbl_errorMessage.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_errorMessage.ForeColor = SystemColors.Control;
            lbl_errorMessage.Name = name;
            lbl_errorMessage.Size = new Size(700, 23);
            lbl_errorMessage.TabIndex = 3;
            lbl_errorMessage.Text = text;
            lbl_errorMessage.TextAlign = ContentAlignment.MiddleRight;

            Controls.Add(lbl_errorMessage);
        }

        public void initializeLabel(String name, String text)
        {
            lbl_name = new Label();

            lbl_name.Dock = DockStyle.Left;
            lbl_name.Font = new Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_name.Name = name;
            lbl_name.Size = new Size(400, 32);
            lbl_name.TabIndex = 0;
            lbl_name.Text = text;

            inputBottomPanel.Controls.Add(lbl_name);
        }

        public void initializeInputField(String name, String typeConstant)
        {
            switch(typeConstant)
            {
                case Constants.INPUT_TYPE_NUMERIC_UP_DOWN:
                    input_field = new NumericUpDown();
                    break;
                case Constants.INPUT_TYPE_TEXT_BOX:
                    input_field = new TextBox();
                    break;
                case Constants.INPUT_TYPE_COMBO_BOX:
                    ComboBox comboBox = new ComboBox();
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    input_field = comboBox;
                    break;
                default:
                    return;
            }

            input_field.Dock = DockStyle.Right;
            input_field.Font = new Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            input_field.Name = name;
            input_field.Size = new Size(300, 32);
            input_field.TabIndex = 0;

            inputBottomPanel.Controls.Add(input_field);
        }
        //input_field.ValueChanged += new System.EventHandler(UserInput_Load);N

        public bool submit()
        {
            return submit(true);
        }

        public bool submit(bool numericExpected)
        {
            if (defaultValue == null)
            {
                try
                {
                    switch (input_field)
                    {
                        case NumericUpDown numericUpDown:
                            validationSuccess = ((NumericUpDown)input_field).Value > 0;
                            break;
                        case TextBox textBox:
                            if(numericExpected)
                            {
                                validationSuccess = double.Parse(((TextBox)input_field).Text) > 0;
                            } else
                            {
                                validationSuccess = ((TextBox)input_field).Text.Length > 0;
                            }
                            break;
                        case ComboBox comboBox:
                            validationSuccess = ((ComboBox)input_field).SelectedValue != "";
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("UserInput Submit ist fehlgeschlagen");
                    Console.WriteLine("Source: " + e.Source);
                }
            } else
            {
                return true;
            }
            
            if (!validationSuccess) validationFailed();
            return validationSuccess;
        }

        public void validationFailed()
        {
            lbl_errorMessage.ForeColor = Color.Red;
            inputAfterValidatoinFailed = new System.EventHandler(inputAfterFailedValidation);
            
            switch (input_field)
            {
                case NumericUpDown numericUpDown:
                    ((NumericUpDown)input_field).ValueChanged += inputAfterValidatoinFailed;
                    break;
                case TextBox textBox:
                    ((TextBox)input_field).TextChanged += inputAfterValidatoinFailed;
                    break;
                case ComboBox comboBox:
                    ((ComboBox)input_field).SelectedValueChanged += inputAfterValidatoinFailed;
                    break;
                default:
                    return;
            }
        }

        private void inputAfterFailedValidation(object sender, EventArgs e)
        {
            lbl_errorMessage.ForeColor = SystemColors.Control;
            switch (input_field)
            {
                case NumericUpDown numericUpDown:
                    ((NumericUpDown)input_field).ValueChanged -= inputAfterValidatoinFailed;
                    break;
                case TextBox textBox:
                    ((TextBox)input_field).TextChanged -= inputAfterValidatoinFailed;
                    break;
                case ComboBox comboBox:
                    ((ComboBox)input_field).SelectedValueChanged -= inputAfterValidatoinFailed;
                    break;
                default:
                    return;
            }
        }

        public object getValue()
        {
            if (validationSuccess)
            {
                switch (input_field)
                {
                    case NumericUpDown numericUpDown:
                        return ((NumericUpDown)input_field).Value;
                    case TextBox textBox:
                        return ((TextBox)input_field).Text;
                    case ComboBox comboItem:
                        return ((ComboBox)input_field).SelectedItem;
                }
            }
            else if (defaultValue != null)
            {
                return defaultValue;
            } else
            {
                throw new Exception();
            }
            return null;
        }

        /*public void addComboBoxItems(ComboItem[] dataSource)
        {
            if (input_field is ComboBox) {
                ((ComboBox)input_field).DisplayMember = ;
                ((ComboBox)input_field).ValueMember = ID;
                ((ComboBox)input_field).DataSource = dataSource;
            }
            else
                Console.WriteLine("UserInput.addComboBoxItems(ComboItem[]). Input Typ ist nicht ComboBox");
        }*/
    }
}
