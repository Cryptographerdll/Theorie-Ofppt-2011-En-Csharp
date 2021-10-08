using System;
using System.Collections.Generic;
using System.Text;

namespace Theorie_2011_Focus
{
    class DéveloppeurInterne : DéveloppeurExterne
    {
            /*
             *  Interne :
             *   Salaire = salaire fixe (5000 ou 8000) + Nombre heures travaillés * taux horaire;
          
             *  Externe :
             *   Salaire = Nombre heures travaillés * taux horaire;
             *   
             *   Questions :
             *   1- Créer les Classes développeur intern et extern avec un constructeur d'initialisation est les methodes d'accées aux proprietés . Les deux classes sont en relation d'héritage . (2Pts) 
             *   
             *   2-Ajouter aux classes créées en 1 , la Méthode de Calcul_Salaire (); Qui recoit comme paramétre le nombre d'heures à payer ( dans le cas de developpeur interne ce nombre représente 
             *     les heures supplémentaires travaillée qui doivent être payées en plus de salaire fixe) et qui calcule le salaire d'un développeur selon les régles de calcule mentionnées ci-dessus . on demande
             *     que cette methode soit polymorphique . (2Pts) 
             */
        private string _categorie;
        private double _salaire;

        #region "Setters"
         public void _setCategorie(string Categorie)
        {
            this._categorie = Categorie;
        }
        #endregion

        #region "Getters"
        public string _getCategorie()
        {
            return this._categorie;
        }
        #endregion

        #region "Constructor Par Défaut"
         public DéveloppeurInterne()
        {

        }
        #endregion

        #region "Constructor 'Initialisation"
        public DéveloppeurInterne(string matricule, string nom, string email, double taux, string Categorie, double Salaire)

           : base(matricule, nom, email, taux)
        {
            this._categorie = Categorie;
            _setSalaire(Salaire);
        }
        #endregion

        #region "Methode Calcule_Salaire"
        public override double Calcul_salaire(int nbr_heures)
        {
            if (_categorie.Equals("J"))
            {
                setTaux(200);
                _setSalaire(_getSalaire() + base.Calcul_salaire(nbr_heures));
            }
            else 
            {
                setTaux(150);
                _setSalaire(_getSalaire() + base.Calcul_salaire(nbr_heures));
            }
            return _getSalaire();
        }
        #endregion
    }
}
