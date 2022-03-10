using leLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace leLab.Views.trainig
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        List<Vehicules> vehicules;
        List<Vehicules> vehicules2;
        /*List<List<Vehicules>> vehicules3;*/
        public Page2()
        {
            InitializeComponent();

            vehicules = new List<Vehicules>();
            vehicules.Add(new Vehicules{ Titre = "VSAV", Cod = "Disponible", Name = "Disponibe", Available = false, NbrPompier = 3 , Image = "https://vehicule-pompiers.fr/fr/wp-content/uploads/2020/03/vehicule-pompiers-renault-master-orion-vsav-2020.jpg"});
            vehicules.Add(new Vehicules { Titre = "VSAV", Cod = "Sur les lieux", Name = "Sur les lieux", Available = true, NbrPompier = 3, Image = "https://vehicule-pompiers.fr/fr/wp-content/uploads/2020/03/vehicule-pompiers-renault-master-orion-vsav-2020.jpg" });
            vehicules.Add(new Vehicules { Titre = "VSAV", Cod = "En route", Name = "En route", Available = true, NbrPompier = 3, Image = "https://vehicule-pompiers.fr/fr/wp-content/uploads/2020/03/vehicule-pompiers-renault-master-orion-vsav-2020.jpg" });
            vehicules.Add(new Vehicules { Titre = "CCFM", Cod = "Disponible radio", Name = "Disponibe radio", Available = false, NbrPompier = 4, Image = "https://www.desautel-firetrucks.com/wp-content/uploads/2020/09/presentation-ccfm-768x0-c-default.jpg" });
            
            listView.ItemsSource = vehicules;

            vehicules2 = new List<Vehicules>();
            
            listView2.ItemsSource = vehicules2;
            Tri(vehicules, vehicules2);

        }
        private List<Vehicules>Tri(List<Vehicules> v, List<Vehicules> v2)
        {
            for (int i = 0; i < v.Count; i++)
            {
                if(v[i].Available == false)
                {
                    v2.Add(v[i]);
                    v.RemoveAt(i);
                }
            }
            Console.WriteLine(v2);
            return v2;
        }

    }
}