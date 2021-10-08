using System;

namespace Theorie_2011_Focus
{
    class Program
    {
        static void Main(string[] args)
        {
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

            DéveloppeurInterne di = new DéveloppeurInterne("D1", "Khalil Abil", "Developper.web.entrepreneur@gmail.com",0,"J",5000);
            DéveloppeurInterne di1 = new DéveloppeurInterne("D1", "Khalil Abil", "Developper.web.entrepreneur@gmail.com", 0, "S", 8000);

            DéveloppeurExterne de = new DéveloppeurExterne("D2", "Amine Qamar", "Amine123@gmail.com", 150);
            de.Calcul_salaire(10);

            Projet p = new Projet();
            p.AjouterParticipant(di);
            p.AjouterParticipant(di1);
            p.AjouterParticipant(de);

            Console.WriteLine("Salaire: {0}", p.CalculSalaireParticipant());

            Console.ReadLine();
        }
    }
}
