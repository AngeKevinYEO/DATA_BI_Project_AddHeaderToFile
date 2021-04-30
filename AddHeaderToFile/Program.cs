using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddHeaderToFile
{
    class Program
    {
        private static string directoryName = @"D:\TRAtoExcel\Header_Files\";
        private static string fileName = "HeaderExercice.csv";
        string s = ";";

      public static void Main(string[] args)
        {
            Program P = new Program();
            P.addHeader();
        }
        public void addHeader()
        {
            addLine(ExercicegetHeader(), fileName);
        }

        //Compte

        public string ComptegetHeader()
        {
            return "FIXE" + this.s + "IDENTIFIANT" + this.s + "CODE" + this.s + "LIBELLE" + this.s +
              "NATURE" + this.s + "LETTRABLE" + this.s + "POINTABLE" + this.s + "VENTILABLE_AXE_1" +
              this.s + "VENTILABLE_AXE_2" + this.s + "VENTILABLE_AXE_3" + this.s + "VENTILABLE_AXE_4" +
              this.s + "VENTILABLE_AXE_5" + this.s + "TABLE1" + this.s + "TABLE2" + this.s + "TABLE3" +
              this.s + "TABLE4" + this.s + "TABLE5" + this.s + "TABLE6" + this.s + "TABLE7" + this.s +
              "TABLE8" + this.s + "TABLE9" + this.s + "TABLE10" + this.s + "ABREGE" + this.s + "SENS" + this.s + "CORRESP1" + this.s + "CORRESP2"
              + this.s + "TVA" + this.s + "TVAENCAISSEMENT" + this.s + "TPF" + this.s + "CUTOFF" + this.s + "CUTOFFPERIODE" + this.s + "CUTOFFECHUE"
              + this.s + "VISAREVISION" + this.s + "CYCLEREVISION" + this.s + "CUTOFFCOMPTE" + this.s + "CONFIDENTIEL" + this.s +
              "G_QUALIFQTE1" + this.s + "G_QUALIFQTE2" + this.s + "FERME" + this.s + "COLLECTIF" + this.s +
              "EFFET" + this.s + "CENTRALISABLE" + this.s + "VENTILTYPE" + this.s + "RESTRICTIONA1" + this.s +
               "RESTRICTIONA2" + this.s + "RESTRICTIONA3" + this.s + "RESTRICTIONA4" + this.s + "RESTRICTIONA5" + this.s +
               "TVASURENCAISS" + this.s + "EXTOURNE";

        }

        //Ecriture 
        public string EcrituregetHeader()
        {
            return "JOURNAL" + this.s + "DATECOMPTABLE" + this.s + "TYPEPIECE" + this.s + "GENERAL" + this.s + "TYPECPTE" + this.s + "AUXILIAIRE " + this.s +
                "REFINTERNE" + this.s + "LIBELLE" + this.s + "MODEPAIE" + this.s + "ECHEANCE" + this.s +
                "SENS" + this.s + "MONTANT1" + this.s + "TYPEECRITURE" + this.s + "NUMEROPIECE" + this.s +
                "DEVISE" + this.s + "TAUXDEV " + this.s + "CODEMONTANT" + this.s + "MONTANT2" +
                this.s + "MONTANT3" + this.s + "ETABLISSEMENT" + this.s + "AXE" + this.s + "NUMECHE";

        }

        // Exercice 
        public string ExercicegetHeader()
        {
            return "FIXE" + this.s + "IDENTIFIANT" + this.s + "CODE" + this.s + "DATEDEBUT" + this.s +
                   "DATEFIN" + this.s + "ETATCPTA" + this.s + "ETATBUDGET" + this.s + "LIBELLE" + this.s + "ETATANO" + this.s +
                   "DATECREATION";
        }

        //Journal 
        public string JournalgetHeader()
        {
            return "FIXE" + this.s + "IDENTIFIANT" + this.s + "CODE" + this.s + "LIBELLE" + this.s +
                "NATURE" + this.s + "SOUCHEN" + this.s + "SOUCHES" + this.s + "COMPTE" + this.s +
                "AXE" + this.s + "MODESAISIE" + this.s + "CPTAUTO" + this.s + "CPTINT" + this.s +
                "ABREGE" + this.s + "CODEEXPERT" + this.s + "FERME" + this.s + "CONTREPARTIEAUX" +
                this.s + "EFFET" + this.s + "MULTIDEVISE" + this.s + "CENTRALISABLE" + this.s + "AEXTOURNER"
                + this.s + "EXCLUDOSECO";
        }

        public static void addLine(string line, string path)
        {
              
            try
            {               
                Directory.CreateDirectory(@directoryName);
                StreamWriter writer = new StreamWriter(@directoryName + path, true);
                writer.WriteLine(line); // Ecriture dans le fichier
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
