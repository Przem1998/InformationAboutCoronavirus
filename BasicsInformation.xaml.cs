using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace InformationAboutCoronavirus
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BasicsInformation : Page
    {
        public BasicsInformation()
        {
            this.InitializeComponent();
            Question1.Text = "Czym jest koronawirus?";
            Answer1.Text = "Jest to wirus RNA osłonięty błoną tłuszczową (lipidową). " +
                "Dzięki takiej budowie można mu zapobiegać przez zastosowanie środków chemicznych, takich jak zwykłe mydło, " +
                "alkohol min. 60-70%, preparaty do dezynfekcji i inne wirusobójcze.";
            Question2.Text = "Jaką chrobę wywołuje koronawirus?";
            Answer2.Text = "Nowy koronawirus SARS - Cov - 2 wywołuje chorobę o nazwie COVID - " +
                "19.Najczęściej występujące objawy choroby to gorączka, kaszel, duszność, problemy z oddychaniem.Chorobie mogą towarzyszyć bóle mięśni i zmęczenie ";
            Question3.Text = "Na czym polega leczenie?";
            Answer3.Text = "Decyzję o sposobie leczenia podejmuje lekarz. Leczenie jest wyłącznie objawowe, czyli polega na leczeniu objawów choroby, takich jak gorączka " +
                "lub problemy z oddychaniem. W literaturze naukowej opisuje się przypadki skutecznego wyleczenia pacjentów zakażonych koronawirusem za pomocą dotychczas" +
                " znanych leków. 13 marca 2020 r. Urząd Rejestracji Produktów Leczniczych, Wyrobów Medycznych i Produktów Biobójczych (URPL) wydał pozytywną decyzję " +
                "w sprawie zmiany do pozwolenia na dopuszczenie do obrotu dla leku zawierającego chlorochinę, polegającą na dodaniu nowego wskazania terapeutycznego: " +
                "„Leczenie wspomagające w zakażeniach koronawirusami typu beta takimi jak SARS-CoV, MERS-CoV i SARS-CoV-2”. Jak dotąd nie są dostępne dane dotyczące " +
                "skuteczności chlorochiny u chorych z COVID-19 poza Chińską Republiką Ludową. Producent zabezpieczył zapas leku na potrzeby Ministerstwa Zdrowia oraz " +
                "Agencji Rezerw Materiałowych. Zgodnie z deklaracją producenta, chlorochina będzie dystrybuowana do pacjentów z COVID-19 zgodnie z dyspozycjami Ministra Zdrowia. ";
            Question4.Text = "Czy są jakieś specialne leki zapbiegające nowemu koronawirsowi lub leczące go?";
            Answer4.Text = "Do tej pory nie ma konkretnego leku zalecanego do zapobiegania lub leczenia nowego koronawirusa. Osoby zakażone wirusem otrzymują leczenie objawowe" +
                " oraz leczenie ewentualnych powikłań bakteryjnych. Jednocześnie 13 marca 2020 r. Urząd Rejestracji Produktów Leczniczych, Wyrobów Medycznych i Produktów Biobójczych (URPL)" +
                " wydał pozytywną decyzję w sprawie zmiany do pozwolenia na dopuszczenie do obrotu dla leku zawierającego chlorochinę, polegającą na dodaniu nowego wskazania terapeutycznego:" +
                " „Leczenie wspomagające w zakażeniach koronawirusami typu beta takimi jak SARS-CoV, MERS-CoV i SARS-CoV-2”. Jak dotąd nie są dostępne dane dotyczące skuteczności chlorochiny" +
                " u chorych z COVID-19 poza Chińską Republiką Ludową. Producent zabezpieczył zapas leku na potrzeby Ministerstwa Zdrowia oraz Agencji Rezerw Materiałowych. Zgodnie z deklaracją" +
                " producenta, chlorochina będzie dystrybuowana do pacjentów z COVID-19 zgodnie z dyspozycjami Ministra Zdrowia.";
            Question5.Text = "Czy osoby starsze i młodsze są na równie podatne na koronawirusa?";
            Answer5.Text = "Ludzie w każdym wieku mogą zostać zainfekowani przez nowy koronawirus. Osoby starsze, a także osoby z istniejącymi schorzeniami przewlekłymi (takimi jak astma, cukrzyca," +
                " choroby serca) wydają się bardziej podatne ma wystąpienie cięższych objawów choroby. WHO zaleca osobom w każdym wieku podjęcie kroków w celu ochrony przed wirusem, np. poprzez " +
                "przestrzeganie zasad higieny rąk i higieny dróg oddechowych.";
            Question6.Text = "Ile się czeka na wyniki testu koronawirusa?";
            Answer6.Text = "Samo badanie próbki trwa kilka godzin. Jeśli badanie trzeba powtórzyć, to ocena pobranego wymazu może trwać nawet kilkadziesiąt godzin. Należy doliczyć czas od pobrania " +
                "do przewiezienia próbki do laboratorium (to zależy od tego, jak daleko jest miejsce, gdzie pobrano wymaz, od najbliższego laboratorium wykonującego badanie). Wszystko zależy zatem od logistyki.";
        }

        private void Video_Tapped(object sender, TappedRoutedEventArgs e)
        {

            Video.AreTransportControlsEnabled = true;

            Video.TransportControls.IsFastForwardButtonVisible = true;
            Video.TransportControls.IsFastForwardEnabled = true;

        }
    }
}
