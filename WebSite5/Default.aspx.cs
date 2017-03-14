using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMaakKaart_Click(object sender, EventArgs e)
    {
        // Het aanmaken van de variabelen  (=Declareren)
        string Naam, Geslacht, Hobby, Opleiding;

        // Het vullen van de variabele Naam (=Initialiseren)
        // met de inhoud (Text) van de Textbox
        Naam = txtNaam.Text;

        // Het vullen van de variabele Geslacht (=Initialiseren)
        // met de inhoud (Text) van de Textbox
        Geslacht = rbGeslacht.SelectedValue;

        // Het vullen van de variabele Hobby (=Initialiseren)
        // met de inhoud (Text) van de Textbox
        Opleiding = cbOpleiding.SelectedValue;
        Hobby = "hobby: ";
        if (chkHobby.Items[0].Selected)
        {
            Hobby += "Gamen ";
        }
        if (chkHobby.Items[1].Selected)
        {
            Hobby += "Programmeren";
        }

        // Het leeg maken van het text blok
        Label1.Text = (" ");
        // Het Schrijven van Naam
        Label1.Text += ("Naam: " + Naam + "<br />");
        // Het Schrijven van Hobby
        Label1.Text += (Hobby + "<br />");
        // Het Schrijven van Opleiding
        Label1.Text += ("Opleiding: " + Opleiding + "<br />");
        // Het Schrijven van Geslacht
        Label1.Text += ("Geslacht: " + Geslacht + "<br />");
    }



    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (Radiobl.SelectedValue == "1")
        {
            Panel1.Visible = true;
        }
        else if (Radiobl.SelectedValue == "2")
        {
            Panel1.Visible = false;
        }
    }
}