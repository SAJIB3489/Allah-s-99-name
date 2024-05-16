using System;

namespace PrintFriends
{
    class Program
    {
    static void print(string s)
        {
            foreach (var iteam in s)
            {
                Console.Write(iteam);
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine( );
        }
        static void Main(string[] args)
        {
            string[] Allah = { "1.AR-RAHMAAN = The Most or Entirely Merciful",
                               "2.AR-RAHEEM = The Bestower of Mercy",
                               "3.AL-MALIK = The King and Owner of Dominion",
                               "4.AL-QUDDUS = The Absolutely Pure",
                               "5.AS-SALAAM = The All Mighty",
                               "6.AL-MUMIN = The One Who gives Emaan and Security",
                               "7.AL-MUHAYMIN = The Guardian, The Witness, The Overseer",
                               "8.AL-AZEEZ = The All Mighty",
                               "9.AL-JABBAR = The Compeller, The Restorer",
                               "10.AL-MUTAKABBIR = The Supreme, The Majestic",
                               "11.AL-KHAALIQ = The Creator, The Maker",
                               "12.AL-BAARI = The Originator",
                               "13.AL-MUSAWWIR = The Fashioner",
                               "14.AL-GHAFFAR = The All- and Oft-Forgiving",
                               "15.AL-WAHHAAB = The Giver of Gifts",
                               "16.AL-WAHHAAB = The Giver of Gifts",
                               "17.AR-RAZZAAQ = The Provider",
                               "18.AL-FATTAAH = The Opener, The Judge",
                               "19.AL-ALEEM = The All-Knowing, The Omniscient",
                               "20.AL-QAABID = The Withholder",
                               "21.AL-BAASIT = The Extender",
                               "22.AL-KHAAFIDH = The Reducer, The Abaser",
                               "23.AR-RAAFI = The Exalter, The Elevator",
                               "24.AL-MUIZZ = The Honourer, The Bestower",
                               "25.AL-MUZIL = The Dishonourer, The Humiliator",
                               "26.AS-SAMEE = The All-Hearing",
                               "27.AL-BASEER = The All-Seeing",
                               "28.AL-HAKAM = The Judge, The Giver of Justice",
                               "29.AL-ADL = The Utterly Just",
                               "30.AL-LATEEF = The Subtle One, The Most Gentle",
                               "31.AL-KHABEER = The Acquainted, the All-Aware",
                               "32.AL-HALEEM = The Most Forbearing",
                               "33.AL-ATHEEM = The Magnificent, The Supreme ",
                               "34.AL-GHAFOOR = The Forgiving, The Exceedingly Forgiving",
                               "35.ASH-SHAKOOR = The Most Appreciative",
                               "36.AL-ALEE = The Most High, The Exalted",
                               "37.AL-KABEER = The Greatest, The Most Grand",
                               "38.AL-HAFEEDH = The Preserver, The All-Heedful and All-Protecting",
                               "39.AL-MUQEET = The Sustainer",
                               "40.AL-HASEEB = The Reckoner, The Sufficient",
                               "41.AL-JALEEL = The Majestic",
                               "42.AL-KAREEM = The Most Generous, The Most Esteemed",
                               "43.AR-RAQEEB = The Watchful",
                               "44.AL-MUJEEB = The Responsive One",
                               "45.AL-WAASI = The All-Encompassing, the Boundless",
                               "46.AL-HAKEEM = The All-Wise",
                               "47.AL-WADOOD = The Most Loving",
                               "48.AL-MAJEED = The Glorious, The Most Honorable",
                               "49.AL-BAITH = The Resurrector, The Raiser of the Dead",
                               "50.ASH-SHAHEED = The All- and Ever Witnessing",
                               "51.AL-HAQQ = The Absolute Truth",
                               "52.AL-WAKEEL = The Trustee, The Disposer of Affairs",
                               "53.AL-QAWIYY = The All-Strong",
                               "54.AL-MATEEN = The Firm, The Steadfast",
                               "55.AL-WALIYY = The Protecting Associate",
                               "56.AL-HAMEED = The Praiseworthy",
                               "57.AL-MUHSEE = The All-Enumerating, The Counter",
                               "58.AL-MUBDI = The Originator, The Initiator",
                               "59.AL-MUID = The Restorer, The Reinstater",
                               "60.AL-MUHYEE = The Giver of Life",
                               "61.AL-MUMEET = The Bringer of Death, the Destroyer",
                               "62.AL-HAYY = The Ever-Living",
                               "63.AL-QAYYOOM = The Sustainer, The Self-Subsisting",
                               "64.AL-WAAJID = The Perceiver",
                               "65.AL-MAAJID = The Illustrious, the Magnificent",
                               "66.AL-WAAHID = The One",
                               "67.AL-AHAD = The Unique, The Only One",
                               "68.AS-SAMAD = The Eternal, Satisfier of Needs",
                               "69.AL-QADEER = The Capable, The Powerful",
                               "70.AL-MUQTADIR = The Omnipotent",
                               "71.AL-MUQADDIM = The Expediter, The Promoter",
                               "72.AL-MUAKHKHIR = The Delayer, the Retarder",
                               "73.AL-AWWAL = The First",
                               "74.AL-AAKHIR = The Last",
                               "75.AZ-DHAAHIR = The Manifest",
                               "76.AL-BAATIN = The Hidden One, Knower of the Hidden",
                               "77.AL-WAALI = The Governor, The Patron",
                               "78.AL-MUTAALI = The Self Exalted",
                               "79.AL-BARR = The Source of Goodness, the Kind Benefactor",
                               "80.AT-TAWWAB = The Ever-Pardoning, The Relenting",
                               "81.AL-MUNTAQIM = The Avenger",
                               "82.AL-AFUWW = The Pardoner",
                               "83.AR-RAOOF = The Most Kind",
                               "84.MAALIK-UL-MULK = Master of the Kingdom, Owner of the Dominion",
                               "85.DHUL-JALAALI WAL-IKRAAM = Possessor of Glory and Honour, Lord of Majesty and Generosity",
                               "86.AL-MUQSIT = The Equitable, the Requiter",
                               "87.AL-JAAMI = The Gatherer, the Uniter",
                               "88.AL-GHANIYY = The Self-Sufficient, The Wealthy",
                               "89.AL-MUGHNI = The Enricher",
                               "90.AL-MANI = The Withholder",
                               "91.AD-DHARR = The Distresser",
                               "92.AN-NAFI = The Propitious, the Benefactor",
                               "93.AN-NUR = The Light, The Illuminator",
                               "94.AL-HAADI = The Guide",
                               "95.AL-BADEE = The Incomparable Originator",
                               "96.AL-BAAQI = The Ever-Surviving, The Everlasting",
                               "97.AL-WAARITH = The Inheritor, The Heir",
                               "98.AR-RASHEED = The Guide, Infallible Teacher",
                               "99.AS-SABOOR = The Forbearing, The Patient",
                        
            };
            Console.WriteLine("Press the space bar to display the names of ALLAH.");
            ConsoleKeyInfo keyInfo;
            int counter = 0;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    print(Allah[counter]);
                    counter++;
                }
            } while (counter < Allah.Length);
            Console.WriteLine("End of ALLAH names list.");
        }
    }
}
