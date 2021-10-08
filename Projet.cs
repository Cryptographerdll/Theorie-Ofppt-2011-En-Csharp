using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Theorie_2011_Focus
{
    class Projet
    {
        public ArrayList participants = new ArrayList();

        public void AjouterParticipant(object o)
        {
            participants.Add(o);
        }

        public Double CalculSalaireParticipant()
        {
            Double salaire = 0;

            foreach(Object o in participants)
            {
                if(o is DéveloppeurExterne)
                {
                    var t = (DéveloppeurExterne)o;
                    salaire += t._getSalaire();
                }
                else
                {
                    var t = (DéveloppeurInterne)o;
                    salaire += t._getSalaire();
                }
            }
            return salaire;
        }
    }
}
