using Övning4KlubbEpidemin;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4KlubbEpidemin
{
    internal class Person
    {
        public string Name { get; set; }
        public bool Infected { get; set; }
        public int InfectedWhen { get; set; }
        public bool Immune { get; set; }
        public bool Dead { get; set; }

        public Person()
        {
            Infected = false;
            InfectedWhen = 0;
            Immune = false;
            Dead = false;
            Name = GetRandomName();
        }
        public Person(bool infected)
        {
            Infected = true;
            InfectedWhen = 0;
            Immune = false;
            Dead = false;
            Name = GetRandomName();
        }


        public void InfectedClub()
        {
            
            if (Infected == true && Dead == false)
            {

                InfectedWhen++;
                Random rnd = new Random();
                if (rnd.Next(1, 100) <= 5)
                {
                    Dead = true;
                }
                else if (InfectedWhen == 5)
                {
                    Immune = true;
                    Infected = false;
                }
            }
           
        }
        public void NewInfected()
        {
            if (Infected == false && Immune == false)
                Infected = true;
        }
        public static string GetRandomName()
        {
            string[] allNamnes =
            { "Aaron", "Abbas", "Abbe", "Abdullah", "Abdullahi", "Abel", "Abraham","Adam", "Adel","Adem","Adnan","Adolf", "Adrian", "Adriano", "Agaton",
            "Agust", "Ahmed", "Aksel", "Albert", "Albin", "Aleksander", "Alex","Alexander", "Alexis", "Alf", "Alfons", "Alfred", "Algot", "Ali", "Allan",
            "Alrik", "Alvar", "Alve", "Alvin", "Amadeus", "Amandus", "Amel", "Amir", "Amos", "Anas", "Anders", "André", "Andreas", "Abdrej", "Andrew",
            "Andy", "Angelo", "Ansel", "Ansgar", "Ante", "Anthon","Anthony", "Anton", "Antonio", "Aram", "Arne", "Arnold","Arnulf", "Aron", "Arthur",
            "Arve", "Arvid", "Assar", "Aston", "Atle", "August", "Axel", "Baltsar", "Baran", "Bartolomeus", "Bastian", "Ben", "Bengt", "Benjamin", "Berengar",
            "Bernhard", "Bernt", "Bert", "Berthold", "Bertil", "Bill", "Billy", "Baltsar", "Baran", "Bartolomeus", "Bastian", "Ben", "Bengt", "Benjamin",
            "Berengar", "Bernhard", "Bernt", "Bert", "Berthold", "Bertil", "Bill", "Billy", "Birger", "Bjarne", "Björn", "Bo", "Bob", "Boris", "Börje", "Botvid",
            "Brian", "Bror", "Bruno", "Brynolf","Calle", "Carl", "Carl-Johan","Carlos","Caspar","Casper","Cevin","Charles","Charlie","Chris","Christian",
            "Christofer","Christoffer","Christopher","Claes","Colin","Conny","Conrad","Cornelius","Dag","Dan","Daniel","Danilo","Danny","Dante","David","Denis",
            "Deniz","Dennis","Denniz","Dick","Didrik","Dilan","Dominic","Douglas","Dylan","Ebbe","Eddie","Eddy","Edgar","Edmund","Edvard","Edvin","Edward",
            "Edwin","Egil","Egon", "Eilert","Einar","Eli","Eliah","Elias","Elis","Elliot","Elliott","Ellis","Elmer","Elof","Elvin","Elvis","Elwin","Emanuel",
            "Emil","Emilio","Emin","Emir","Emmanuel","Emre","Emrik","Enar","Engelbrekt","Enzo","Erhard","Eric","Erik","Erland","Erling","Ernst","Esaias","Esbjörn",
            "Eskil","Eugen","Evald","Evert","Fabian","Felix","Ferdinand","Filip","Filiph","Fingal","Finn","Folke","Frank","Frans","Franz","Fred","Freddy",
            "Fredric","Fredrik","Frej","Fridolf","Fritiof","Fritz","Gabriel","Georg","George","Gerd","Gerhard","Germund","Gert","Gilbert","Glenn","Göran",
            "Gordon","Gösta","Göte","Gottfrid","Gotthard","Greger","Grim","Gudmar","Gudmund","Gunder","Gunnar","Gustaf","Gustav","Gusten", "Hadi","Håkan",
            "Hakon","Halvar","Halvard","Hampus","Hannes","Hans","Harald","Harry","Hasan","Hassan","Hector","Hektor","Helge","Helmer","Hemming","Henning","Henric",
            "Henrik","Henry","Herbert","Herman","Hilding","Hilmer","Hjalmar","Holger","Holger","Holmfrid","Hubert","Hugo","Ian","Ibrahim","Ilyas","Ingemar",
            "Ingemund","Ingvar","Isaac","Isac","Isak","Ismail","Israel","Ivan","Ivar","Jacob","Jake","Jakob","James","Jamie","Jan","Jarl","Jasper","Jens",
            "Jerry","Jesper","Jim","Jimmie","Jimmy","Joachim","Joacim","Joakim","Joar","Joel","Johan","Johannes","John","Johnny","Jon","Jona","Jonas","Jonatan",
            "Jonathan","Jonny","Jörgen","Josef","Joseph","Julian","Julius","Justin","Justus","Kaj","Kalle","Karim","Karl","Kaspar","Kasper","Kenneth",  "Kenny",
            "Kent","Kevin","Kian","Kim","Kjell","Klas","Klemens","Knut","Konrad","Konstantin","Krister","Kristian","Kristoffer","Kurt","Laban","Lage","Lars",
            "Leandro","Leif","Lennart","Lennox","Leo","Leon","Leonard","Leopold","Lex","Liam","Linus","Lion","Loa","Loke","Lorentz","Love","Lowe","Lucas","Ludvig",
            "Ludwig","Luka","Lukas","Magnus","Maksim","Malcolm","Malek","Malik","Malte","Manfred","Manne","Måns","Manuel","Marc","Marcel","Marcus","Mark","Markus",
            "Marlon","Mårten","Martin","Marvin","Matheo","Matheus","Mats","Matteo","Matteus","Matthias","Mattias","Mattis","Mauritz","Max","Maximiliam","Maximilian",
            "Maximillian","Maximus","Mehmet","Melker","Melvin","Melwin","Michael","Michel","Miguel","Mika","Mikael","Mike","Milan","Miliam","Milton","Mio","Miran",
            "Miro","Mohammed","Morgan","Moses","Mostafa","Muhammad","Muhammed","Mustafa","Natanael","Natanel","Nathan","Nathanael","Nathaniel","Nick","Nicklas",
            "Niclas","Nicolai","Nicolas","Niklas","Nikolaj","Nikolaus","Nilo","Nils","Nima","Nino","Noa","Noah","Noak","Nore","Odin","Ola","Olaus","Olav","Oliver",
            "Oliwer","Olle","Olof","Olov","Omar","Orvar","Oscar","Oskar","Osman","Ossian","Osvald","Otto","Ove","Pål","Pär","Patric","Patrick","Patrik","Paul",
            "Pelle","Per","Peter","Petter","Philip","Pierre","Pontus","Rafael","Ragnar","Ralf","Rami","Raoul","Rasmus","Reidar","Reine","Reinhold","Richard",
            "Rickard","Ricky","Ridwan","Rikard","River","Robert","Robin","Roger","Roland","Rolf","Roman","Romeo","Ronald","Ronny","Roy","Ruben","Rudolf","Rune",
            "Rutger","Ryan","Said","Sakarias","Salomon","Sam","Samir","Samuel","Sander","Scott","Sean","Sebastian","Set","Seth","Seved","Severin","Sigge",
            "Sigurd","Sigvard","Simon","Sivert","Sixten","Sonny","Sören","Staffan","Stefan","Stellan","Sten","Steven","Stig","Sture","Styrbjörn","Sune","Svante",
            "Sven","Sverker","Sylvester","Tage","Ted","Teddy","Teo","Teodor","Theo","Theodor","Theodore","Thomas","Thor","Thure","Tibirtus","Tim","Timmie","Timmy",
            "Timothy","Tino","Tintin","Titus","Tobias","Tom","Tomas","Tommy","Tony","Tor","Torbjörn","Tord","Tore","Torgny","Torkel","Torleif","Torvald","Troy",
            "Tryggve","Ture","Tyko","Ulf","Ulrik","Uno","Urban","Valdemar","Valentin","Valfrid","Valle","Valter","Verner","Victor","Vidar","Vigor","Viking",
            "Viktor","Vilgot","Vilhelm","Ville","Villiam","Vince","Vincent","Vladimir","Volmar","Waldemar","Walter","Wictor","Wiktor","Wilhelm","Wille","William",
            "Willy","Wilton","Wincent","Winston","Xander","Xavier","Yngve","Zacharias","Zander","Åke",
            "Abigail","Ada","Adela","Adele","Adèle","Adelina","Adina","Adine","Adna","Adriana","Agnes","Aicha","Aida","Aina","Aisha","Ajla","Alba","Albina","Alea",
            "Aleksandra","Alessia","Alexandra","Alexia","Alexis","Alexsandra","Aleyna","Alice","Alicia","Alida","Alina","Aline","Alisa","Alissa","Allie","Allis",
            "Ally","Alma","Alva","Alwa","Alvina","Alyssa","Amal","Amalia","Amanda","Amber","Amela","Amelia","Amelie","Amélie","Amie","Amilia","Amina","Amira",
            "Amna","Amy","Ana","Anastasia","Anastasija","Andrea","Andréa","Angela","Angelica","Angelika","Angelina","Anisa","Anita","Anja","Anna","Annabelle","Anni",
            "Annie","Annika","Antonia","Anya","Aprilia","Ariana","Arwen","Asma","Asta","Astrid","Athena","Aurora","Ava","Awa","Avin","Aya","Ayla","Aylin","Azra",
            "Bea","Beata","Beatrice","Beda","Belinda","Bella","Belle","Benin","Berfin","Betty","Bianca","Billie","Blanka","Blenda","Bodil","Boel","Bonnie","Britta",
            "Caisa","Cajsa","Camilla","Carla","Carmen","Carolin","Carolina","Caroline","Casandra","Cassandra","Cecilia","Celia","Celina","Celine","Céline","Chanel",
            "Chanelle","Charlie","Charlotta","Charlotte","Chelsea","Chloe","Chloé","Christina","Christine","Cindy","Clara","Claudia","Cleo","Cornelia","Dahlia",
            "Daisy","Dalia","Dana","Dania","Daniela","Daniella","Deborah","Denice","Denise","Denize","Desirée","Destiny","Diana","Dilan","Dilara","Dima","Dina",
            "Disa","Donia","Donya","Doris","Ebba","Eda","Edda","Eden","Edessa","Edit","Edith","Eila","Eira","Ela","Eleanor","Elena","Eleonor","Eleonora","Elfrida",
            "Eliana","Elicia","Elif","Elin","Elina","Eline","Elinor","Elisa","Elisabet","Elisabeth","Elise","Elisia","Elissa","Eliza","Elizabeth","Elize","Ella",
            "Elle","Ellen","Elli","Ellie","Ellinor","Ellinore","Elly","Elma","Elmedina","Elna","Elsa","Elsie","Elva","Elvina","Elvira","Elwira","Ema","Embla","Emeli",
            "Emelia","Emelie","Emely","Emilia","Emilie","Emilija","Emily","Emina","Emma","Emmelie","Emmi","Emmie","Emmy","Emy","Engla","Enya","Erica","Erika",
            "Erina","Erna","Erza","Esma","Esmeralda","Esra","Estelle","Ester","Esther","Estrid","Eva","Evelin","Evelina","Eveline","Evelyn","Evin","Fannie","Fanny",
            "Fatima","Fatma","Felicia","Felizia","Fia","Fideli","Filippa","Fiona","Flora","Franka","Fredrica","Fredrika","Fredrike","Freija","Freja","Freya","Freyja",
            "Frida","Gabriela","Gabriella","Gabrielle","Gerda","Gina","Gloria","Grace","Greta","Gry","Hafsa","Hailey","Hailie","Haley","Hana","Hanan","Hanin",
            "Hanna","Hannah","Harriet","Havanna","Havin","Haylie","Hedda","Hedvig","Heidi","Helen","Helena","Helga","Helin","Henny","Henrietta","Hiba","Hilda",
            "Hillevi","Hilma","Hoda","Holly","Huda","Hulda","Ida","Idun","Ilma","Ilona","Ilse","Iman","Ina","Indra","Ines","Inez","Ingrid","Irene","Irem","Iris",
            "Irja","Irma","Isa","Isabel","Isabell","Isabella","Isabelle","Isadora","Isis","Isolde","Isra","Iza","Izabel","Izabell","Izabella","Izabelle","Jackie",
            "Jacqueline","Jana","Janina","Jasmin","Jasmina","Jasmine","Jeanette","Jenna","Jennie","Jennifer","Jenny","Jessica","Jessie","Jessika","Jill","Joanna",
            "Johanna","Jolene","Jolie","Jolin","Jolina","Joline","Joni","Jonna","Josefin","Josefina","Josefine","Josephine","Joy","Judit","Judith","Juli","Julia",
            "Julie","Juliette","Juni","Junia","Junie","Juno","Kajsa","Karin","Karla","Karolin","Karolina","Katarina","Katja","Kayla","Kelly","Kendra","Kerstin",
            "Khadija","Kiara","Kim","Kimberly","Kira","Kitty","Klara","Kristin","Kristina","Laila","Lamar","Lamis","Lana","Lara","Laura","Lava","Lavin","Lea","Leah",
            "Lee","Leia","Leiah","Leija","Leila","Leja","Lejla","Lena","Leona","Leone","Leonie","Leonora","Lexie","Leya","Leyla","Li","Lia","Liana","Lillemor",
            "Lilian","Lilith","Lilja","Lillian","Lillie","Lilly","Lilo","Lily","Lin","Lina","Linda","Line","Linn","Linnea","Linnéa","Lisa","Lisen","Liv","Liva",
            "Livia","Liza","Lizette","Lo","Lola","Lorena","Lorin","Lotta","Lou","Louisa","Louise","Lova","Lowa","Lovelia","Lovis","Lovisa","Lucia","Lucy","Luna",
            "Lycka","Lydia","Lykke","Madeleine","Madelen","Madelene","Madicken","Magda","Magdalena","Maia","Maida","Maija","Maj","Maja","Majken","Malak","Malin",
            "Malou","Malva","Malvina","Manar","Manda","Maram","Maria","Mariam","Marie","Marielle","Marika","Marina","Marion","Marta","Martina","Marwa","Mary",
            "Maryam","Maryama","Maryan","Mathilda","Mathilde","Matilda","Matilde","Maya","Medina","Meija","Meja","Melanie","Melek","Melina","Melinda","Melisa",
            "Melissa","Melody","Merve","Meya","Mia","Micaela","Michaela","Michelle","Mika","Mikaela","Mila","Milena","Miley","Milia","Milla","Millie","Milly",
            "Milou","Mimmi","Mina","Minea","Minelle","Minja","Minna","Minnah","Minou","Mira","Miranda","Mirella","Miriam","Mirjam","Mirna","Moa","Mollie","Molly",
            "Mona","Monika","My","Myra","Märta","Märtha","Nada","Nadia","Nadin","Nadine","Nadja","Naemi","Naima","Najma","Nancy","Nanna","Naomi","Narin","Natali",
            "Natalia","Natalie","Natasha","Nathalie","Nawal","Nea","Neah","Nejdi","Nejla","Nelia","Nell","Nella","Nelli","Nellie","Nelly","Nemi","Nicole","Nicolina",
            "Nike","Niki","Nikita","Nikki","Nikolina","Nilla","Nina","Ninja","Ninni","Nisa","Noa","Noelia","Noelle","Nomi","Noomi","Noor","Nor","Nora","Norah",
            "Norea","Nour","Nova","Nowa","Novalee","Novali","Nova-Li","Novalie","Ofelia","Olga","Olivia","Oliwia","Ophelia","Othilia","Otilia","Ottilia","Pamela",
            "Patricia","Paula","Paulina","Pauline","Penny","Perla","Pernilla","Petra","Petronella","Philippa","Pia","Pixie","Polly","Rahaf","Rahma","Rakel","Rama",
            "Rania","Rawan","Rayan","Rebecca","Rebecka","Regina","Rim","Rita","Rojin","Ronja","Ronya","Rosa","Rosanna","Roxanna","Rut","Ruth","Sabina","Sabrin",
            "Sabrina","Safa","Saga","Sally","Salma","Sama","Samantha","Samira","Sana","Sandra","Sandy","Sanja","Sanna","Sanne","Sara","Sarah","Sasha","Savannah",
            "Selin","Selina","Selma","Shams","Shirin","Sibel","Sidra","Sienna","Signe","Sigrid","Siham","Silje","Silvia","Simona","Simone","Siri","Smilla","Sofi",
            "Sofia","Sofie","Solveig","Sonia","Sonja","Sophia","Sophie","Stella","Stephanie","Stina","Sumaya","Susanna","Svea","Tamara","Tania","Tanja","Tanya",
            "Tara","Tea","Tekla","Telma","Teodora","Terese","Teresia","Tess","Thea","Thelise","Thelma","Theodora","Therese","Therése","Thilda","Thilde","Thindra",
            "Thyra","Tiara","Tiffany","Tilda","Tilde","Tilia","Tilja","Tilly","Tina","Tindra","Tintin","Tone","Tora","Tova","Towa","Tove","Towe","Turid","Tuva",
            "Tuwa","Tuva-Li","Tyra","Ulrika","Ulva","Uma","Unni","Valencia","Valentina","Valeria","Vanesa","Vanessa","Vanja","Vanna","Vega","Vendela","Wendela",
            "Vera","Wera","Veronica","Veronika","Whilma","Victoria","Vida","Viktoria","Vilda","Wilda","Vilhelmina","Wilhelmina","Vilja","Wilja","Villemo","Vilma",
            "Wilma","Viola","Vira","Viva","Yara","Yasmin","Yasmina","Yasmine","Ylva","Ylvali","Yrsa","Yusra","Zelda","Zahra","Zahraa","Zainab","Zandra","Zanna",
            "Zara","Zeinab","Zelda","Zeynep","Zilan","Zoe","Zoey","Zuzanna","Åsa","Ängla"
            };
            Random random = new Random();
            int rnd = random.Next(0, allNamnes.Length - 1);

            return allNamnes[rnd];
        }
        //public static string GetRandomName()
        //{
        //    string[] allNamnes =
        //    {
        //        "Karin",
        //        "Anders",
        //        "Johan",
        //        "Eva",
        //        "Kurt",
        //        "Sven",
        //        "Bengt",
        //        "Elise",
        //        "Erik",
        //        "Håkan",
        //        "Lisa",
        //        "Agnes",
        //        "Erik",
        //        "Arne",
        //        "Agnes",
        //        "Bert",
        //        "Olle",
        //        "Ragnar",
        //        "Anna",
        //        "Love",
        //        "Hugo",
        //        "Måns",
        //        "Sixten",
        //        "Ylva",
        //        "Britta",
        //        "Mattias"

        //    };
        //    Random random = new Random();
        //    int rnd = random.Next(0, allNamnes.Length - 1);

        //    return allNamnes[rnd];

        //}
    }
}


//◦ ◦ Skapa ett objekt: Person, med följande egenskaper
//◦ Smittad (bool)
//◦ SmittadNär(int, personen ska bli frisk igen efter 5 timmar.)
//◦ Immun(bool, en smittad person som blivit frisk kan inte bli sjuk igen)
//◦ Skapa en lista: club, där du stoppar in 20 personer. 
//◦ Ange att EN person är sjuk.
//◦ Loopa igenom listan och anta att varje sjuk person smittar 1(en) annan person per 
//timme.
//◦ Första timmen smittar alltså den enda sjuka personen en annan person. 
//◦ Andra timmen smittar dessa två personer ytterligare varsin person
//◦ Tredje timmen smittar alla fyra ytterligare fyra personer…osv
//◦ När 5 timmar gått blir första personen frisk, och smittar ingen längre (och är immun), 
//men de andra fortsätter smitta…
//◦ Stega fram timmarna med en tangenttryckning, en timme per tryck.
//◦ Visa I konsollen vilka som är smittade, och hur många som är immuna. 
//◦ Visa också hur många timmar som går.
//◦ Hur många timmar tar det innan alla är immuna?