using System;
using System.Collections.Generic;
using System.Text;

namespace Theorie_2011_Focus
{
    class DéveloppeurExterne
    {
        #region "Exercice Text et Questions"
        /* on souhaite créer une application C# qui gére le système d'information d'une société de création de logiciels 
             * Les Développeurs sont caractérisés en général par un matricule , un nom , un email 
             * Par défaut la majorité des développeurs qui travaillent à la société sont des développeurs externes qui sont payés a l'heure travaillée .
             * Le taux horaire appliqué est négocié avec le développeur externe au moment de son engagement .
             * certains de ces développeurs sont recrutés en permanence par la société , Ils sont dis des développeurs internes ou permanentes .
             * Les développeurs internes percoivent un salaire mensuel dépendant de leur catégorie (S : Senior , J: Junior), Les juniors touchent un salaire de 5000 Dh/Mois 
             * et les Seniors touchent un salaire de 8000 Dh/Mois , Dans les deux cas ce salaire représente le salaire fixe d'un développeur interne . Ils bénéficient également des heures
             * supplémentaires payés , à la fin de chaque Mois , un taux de 150Dh/Heure pour les juniors et 200Dh/Heure pour les seniors , En résume le salaire mensuel d'un développeur est
             * calculé selon la régle suivante :
             * 
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
        #endregion 
        private string _matricule;
        private string _nom;
        private string _email;
        private double _taux;
        private double _salaire;

        #region "Setters"
        public void setMatricule(string matricule)
        {
            this._matricule = matricule;
        }
        public void setNom(string nom)
        {
            this._nom = nom;
        }
        public void setEmail(string email)
        {
            this._email = email;
        }
        public void setTaux(double taux)
        {
            this._taux = taux;
        }
        public void _setSalaire(double salaire)
        {
            this._salaire = salaire;
        }
        #endregion
        #region "Getters"
        public string _getMatricule ()
        {
            return this._matricule;
        }
        public string _getNom()
        {
            return this._nom;
        }
        public string _getEmail()
        {
            return this._email;
        }
        public double _gettaux()
        {
            return this._taux;
        }
        public double _getSalaire()
        {
            return this._salaire;
        }
        #endregion

        #region "Constructor Par Defaut"
        public DéveloppeurExterne()
        {

        }
        #endregion

        #region "Constructor d'Initialisation"
        public DéveloppeurExterne(string matricule, string nom, string email, double taux)
        {
            _matricule = matricule;
            _nom = nom;
            _email = email;
            _taux = taux;
        }
        #endregion

        #region "Method Calcul_salaire"
        public virtual double Calcul_salaire(int nbr_heures) // Développeur externe salaire Mensuel .
        {
            _setSalaire(nbr_heures * _taux);
            return nbr_heures * _taux;
        }
        #endregion
    }
}
