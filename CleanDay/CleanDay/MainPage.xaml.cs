using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace CleanDay
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string message = "";

            if (myTextBox.Text.ToLower()=="cholera")
            {
                message = " SYMPTOMS :\n 1.Watery diarrhea, vomiting, and muscle cramp.\nWithin 24 to 48 hours this symptoms can develop. \n 3.Rapid loss of body fluids and that can\n lead to dehydration and shock.\n\n FIRST AID :\n **REHYDRATION: The Oral Rehydration(ORS) can be reconstituted in\n boiled or bottled water.\n**INTRAVENOUS FLUIDS: During a cholera epidemic people must need\n intravenous fluids. ";
            
            }

            else
            {
                message = " YOU ONLY ABLE TO SEARCH ABOUT \n**CHOLERA\n **Diarrhoea\n **Typhoid\n **Hepatitis \n **Trachoma\n **Schistosomiasis\n **Ascarisis ";
            }

            myTextBlock.Text = message;

            if (myTextBox.Text.ToLower() == "typhoid")
            {
                message = "SYMPTOMS :\n**Symptoms can be mild or severe and include\n sustained fever as high as 39°-40° C.\n**Malaise.\n **Anorexia\n**Headache.\n\nFIRST AID:\n**Health education about personal hygiene\n especially regarding hand-washing after\n toilet use and before food preparation.\n**Provision of a safe water supply.\n**Proper sanitation systems.  ";

 
            }

            else
            {
                message = " YOU ONLY ABLE TO SEARCH ABOUT \n**CHOLERA\n **Diarrhoea\n **Typhoid\n **Hepatitis \n **Trachoma\n **Schistosomiasis\n **Ascarisis ";
            }

            myTextBlock.Text = message;

            if (myTextBox.Text.ToLower() == "diarrhoea")
            {
                message = " SYMPTOMS :\n**Stomach pain, Bloating\n**An urgent need to use the bathroom.\n**Fecal incontinence, Low heart rate\n**Joint pain, Fever.\n\nFIRST AID :\n**Access to safe drinking water.\n**Improved sanitation\nWashing hands with soap ";
            }
            else
            {
                message = " YOU ONLY ABLE TO SEARCH ABOUT \n**CHOLERA\n **Diarrhoea\n **Typhoid\n **Hepatitis \n **Trachoma\n **Schistosomiasis\n **Ascarisis ";
            }
            myTextBlock.Text = message;

            if (myTextBox.Text.ToLower() == "hepatitis")
            {
                message = "SYMPTOMS :\n**General malaise.\n**Muscle pain and joint pain.\n**Sore throat and Runny nose.\nFIRST AID :\n**Take it easy- curtail normal activities\n and spend time resting at home.\n**Drink plenty of clear fluids to preven\n dehydration.\n**Avoid alcoholic and prolonged ";
            }
            myTextBlock.Text = message;
        }
    }
}