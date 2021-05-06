namespace CookShopOnline.Migrations
{
    using CookShopOnline.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CookShopOnline.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CookShopOnline.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            List<Country> countries = new List<Country>
            {
                new Country{ID=1, CountryName="Greece", CountryCode="GR", Regions = new List<Region>(){
                    new Region{ID=1, RegionName="Attica", Cities = new List<City>(){
                        new City { ID = 1 , Name = "Athens"},
                        new City { ID = 2 , Name = "Piraeus"},
                        new City { ID = 3 , Name = "Peristeri"},
                        new City { ID = 4 , Name = "Kallithea"},
                        new City { ID = 5 , Name = "Nikaia"},
                        new City { ID = 6 , Name = "Glyfada"},
                        new City { ID = 7 , Name = "Chalandri"},
                        new City { ID = 8 , Name = "Nea Ionia"},
                        new City { ID = 9 , Name = "Nea Filadelfeia"},
                        new City { ID = 10, Name = "Salamina"},
                        new City { ID = 11, Name = "Elefsina"},
                        new City { ID = 12, Name = "Megara"},
                        new City { ID = 13, Name = "Pefki"},
                        new City { ID = 14, Name = "Paiania"},
                        new City { ID = 15, Name = "Lykovrysi"},
                        new City { ID = 16, Name = "Porto Rafti"},
                        new City { ID = 17, Name = "Zefiri"},
                        new City { ID = 18, Name = "Spata"},
                        new City { ID = 19, Name = "Nea Peramos"},
                        new City { ID = 20, Name = "Marathonas"},
                        new City { ID = 21, Name = "Lavrio"},
                        new City { ID = 22, Name = "Aigina"},
                        new City { ID = 23, Name = "Anoixi"},
                        new City { ID = 24, Name = "Anavyssos"},
                        new City { ID = 25, Name = "Dionysos"},
                        new City { ID = 26, Name = "Magoula"},
                        new City { ID = 27, Name = "Ampelakia"},
                        new City { ID = 28, Name = "Vouliagmeni"},
                        new City { ID = 29, Name = "Kitsi"},
                        new City { ID = 30, Name = "Spetses"},
                        new City { ID = 31, Name = "Kapandriti"},
                        new City { ID = 32, Name = "Ntrafi"},
                        new City { ID = 33, Name = "Saronida"},
                        new City { ID = 34, Name = "Erythres"},
                        new City { ID = 35, Name = "Palaia Fokaia"},
                        new City { ID = 36, Name = "Galatas"},
                        new City { ID = 37, Name = "Nea Smyrni"},
                        new City { ID = 38, Name = "Dafni"},
                        new City { ID = 39, Name = "Agios Dimitrios"},
                        new City { ID = 40, Name = "Korydallos"},
                        new City { ID = 41, Name = "Galatsi"},
                        new City { ID = 42, Name = "Palaio Faliro"},
                        new City { ID = 43, Name = "Agia Varvara"},
                        new City { ID = 45, Name = "Irakleio"},
                        new City { ID = 46, Name = "Agioi Anargyroi"},
                        new City { ID = 47, Name = "Ilion"},
                        new City { ID = 48, Name = "Keratsini"},
                        new City { ID = 49, Name = "Kaisariani"},
                        new City { ID = 50, Name = "Moschato"},
                        new City { ID = 51, Name = "Vrilissia"},
                        new City { ID = 52, Name = "Zografos"},
                        new City { ID = 53, Name = "Petroupoli"},
                        new City { ID = 54, Name = "Cholargos"},
                        new City { ID = 55, Name = "Vyronas"},
                        new City { ID = 56, Name = "Agia Paraskevi"},
                        new City { ID = 57, Name = "Alimos"},
                        new City { ID = 58, Name = "Ilioupoli"},
                        new City { ID = 59, Name = "Melissia"},
                        new City { ID = 60, Name = "Metamorfosi"},
                        new City { ID = 61, Name = "Marousi"},
                        new City { ID = 62, Name = "Argyroupoli"},
                        new City { ID = 63, Name = "Gerakas"},
                        new City { ID = 64, Name = "Psychiko"},
                        new City { ID = 65, Name = "Voula"},
                        new City { ID = 66, Name = "Chaidari"},
                        new City { ID = 67, Name = "Kifisia"},
                        new City { ID = 68, Name = "Pérama"},
                        new City { ID = 69, Name = "Agios Stefanos"},
                        new City { ID = 70, Name = "Acharnes"},
                        new City { ID = 71, Name = "Ano Liosia"},
                        new City { ID = 72, Name = "Rafina"},
                        new City { ID = 73, Name = "Aspropyrgos"},
                        new City { ID = 74, Name = "Koropi"},
                        new City { ID = 75, Name = "Markopoulo"},
                        new City { ID = 76, Name = "Kalyvia Thorikou"},
                        new City { ID = 77, Name = "Oropos"},
                        new City { ID = 78, Name = "Poros"},
                        new City { ID = 79, Name = "Agkistri"},
                        new City { ID = 80, Name = "Mandra"},
                        new City { ID = 81, Name = "Ydra"},
                        new City { ID = 82, Name = "Kythira"}
                    } },
                new Region{ID=2, RegionName="Central Greece", Cities = new List<City>(){
                    new City { ID = 83 , Name = "Chalkida"},
                    new City { ID = 84 , Name = "Lamia"},
                    new City { ID = 85 , Name = "Livadeia"},
                    new City { ID = 86 , Name = "Nea Artaki"},
                    new City { ID = 87 , Name = "Karpenisi"},
                    new City { ID = 88 , Name = "Amfissa"},
                    new City { ID = 89 , Name = "Psachna"},
                    new City { ID = 90 , Name = "Orchomenos"},
                    new City { ID = 91 , Name = "Aliveri"},
                    new City { ID = 92 , Name = "Aliartos"},
                    new City { ID = 93 , Name = "Itea"},
                    new City { ID = 94 , Name = "Istiaia"},
                    new City { ID = 95 , Name = "Schimatari"},
                    new City { ID = 96 , Name = "Kamena Vourla"},
                    new City { ID = 97 , Name = "Spercheiada"},
                    new City { ID = 98 , Name = "Kato Tithorea"},
                    new City { ID = 99 , Name = "Skyros"},
                    new City { ID = 100, Name = "Distomo"},
                    new City { ID = 101, Name = "Domokos"},
                    new City { ID = 102, Name = "Thebes"},
                    new City { ID = 103, Name = "Karystos"},
                    new City { ID = 104, Name = "Stylida"},
                    new City { ID = 105, Name = "Eretria"},
                    new City { ID = 106, Name = "Atalanti"},
                    new City { ID = 107, Name = "Limni"},
                    new City { ID = 108, Name = "Lidoriki"},
                    new City { ID = 109, Name = "Kerasochori"}
                } },
                new Region{ID=3, RegionName="Crete", Cities = new List<City>(){
                    new City { ID = 110, Name = "Irakleio"},
                    new City { ID = 111, Name = "Chania"},
                    new City { ID = 112, Name = "Rethymno"},
                    new City { ID = 113, Name = "Agios Nikolaos"},
                    new City { ID = 114, Name = "Siteia"},
                    new City { ID = 115, Name = "Mournies"},
                    new City { ID = 116, Name = "Souda"},
                    new City { ID = 117, Name = "Kounoupidiana"},
                    new City { ID = 118, Name = "Nerokouros"},
                    new City { ID = 119, Name = "Tympaki"},
                    new City { ID = 120, Name = "Arkalochori"},
                    new City { ID = 121, Name = "Kissamos"},
                    new City { ID = 122, Name = "Malia"},
                    new City { ID = 123, Name = "Kastelli"},
                    new City { ID = 124, Name = "Gazi"},
                    new City { ID = 125, Name = "Moires"},
                    new City { ID = 126, Name = "Peza"},
                    new City { ID = 127, Name = "Perama"},
                    new City { ID = 128, Name = "Gournes"},
                    new City { ID = 129, Name = "Ierapetra"},
                    new City { ID = 130, Name = "Gerani"},
                    new City { ID = 131, Name = "Agioi Deka"},
                    new City { ID = 132, Name = "Tzermiado"},
                    new City { ID = 133, Name = "Spili"},
                    new City { ID = 134, Name = "Ano Viannos"},
                    new City { ID = 135, Name = "Palaiochora"},
                    new City { ID = 136, Name = "Agia Foteini"},
                    new City { ID = 137, Name = "Vryses"},
                    new City { ID = 138, Name = "Anogeia"},
                    new City { ID = 139, Name = "Chora Sfakion"},
                    new City { ID = 140, Name = "Kastri"}
                } },
                new Region{ID=4, RegionName="Central Macedonia", Cities = new List<City>(){
                    new City { ID = 141, Name = "Thessaloniki"},
                    new City { ID = 142, Name = "Serres"},
                    new City { ID = 143, Name = "Katerini"},
                    new City { ID = 144, Name = "Veroia"},
                    new City { ID = 145, Name = "Giannitsa"},
                    new City { ID = 146, Name = "Kilkis"},
                    new City { ID = 147, Name = "Edessa"},
                    new City { ID = 148, Name = "Thermi"},
                    new City { ID = 149, Name = "Alexandreia"},
                    new City { ID = 150, Name = "Diavata" },
                    new City { ID = 151, Name = "Nea Moudania" },
                    new City { ID = 152, Name = "Sindos" },
                    new City { ID = 153, Name = "Epanomi" },
                    new City { ID = 154, Name = "Koufalia" },
                    new City { ID = 155, Name = "Lagkadas" },
                    new City { ID = 156, Name = "Chalastra" },
                    new City { ID = 157, Name = "Nea Kallikrateia" },
                    new City { ID = 158, Name = "Polykastro" },
                    new City { ID = 159, Name = "Litochoro" },
                    new City { ID = 160, Name = "Aridaia" },
                    new City { ID = 161, Name = "Polygyros" },
                    new City { ID = 162, Name = "Neoi Epivates" },
                    new City { ID = 163, Name = "Filyro" },
                    new City { ID = 164, Name = "Skydra" },
                    new City { ID = 165, Name = "Agios Athanasios" },
                    new City { ID = 166, Name = "Nigrita" },
                    new City { ID = 167, Name = "Chortiatis" },
                    new City { ID = 168, Name = "Nea Magnisia" },
                    new City { ID = 169, Name = "Aiginio" },
                    new City { ID = 170, Name = "Nea Raidestos" },
                    new City { ID = 171, Name = "Vasilika" },
                    new City { ID = 172, Name = "Leptokarya" },
                    new City { ID = 173, Name = "Stavros" },
                    new City { ID = 174, Name = "Goumenissa" },
                    new City { ID = 175, Name = "Lagyna" },
                    new City { ID = 176, Name = "Korinos" },
                    new City { ID = 177, Name = "Liti" },
                    new City { ID = 178, Name = "Ierissos" },
                    new City { ID = 179, Name = "Neos Marmaras" },
                    new City { ID = 180, Name = "Kallithea" },
                    new City { ID = 181, Name = "Meliki" },
                    new City { ID = 182, Name = "Nea Triglia" },
                    new City { ID = 183, Name = "Sochos" },
                    new City { ID = 184, Name = "Nea Mesimvria" },
                    new City { ID = 185, Name = "Ormylia" },
                    new City { ID = 186, Name = "Neo Rysi" },
                    new City { ID = 187, Name = "Axioupoli" },
                    new City { ID = 188, Name = "Asprovalta" },
                    new City { ID = 189, Name = "Kolindros" },
                    new City { ID = 190, Name = "Kassandreia" },
                    new City { ID = 191, Name = "Nikiti" },
                    new City { ID = 192, Name = "Ampelokipoi" },
                    new City { ID = 193, Name = "Stavroupoli" },
                    new City { ID = 194, Name = "Kalamaria" },
                    new City { ID = 195, Name = "Sykies" },
                    new City { ID = 196, Name = "Evosmos" },
                    new City { ID = 197, Name = "Peraia" },
                    new City { ID = 198, Name = "Oraiokastro" },
                    new City { ID = 199, Name = "Panorama" },
                    new City { ID = 200, Name = "Irakleia" },
                    new City { ID = 201, Name = "Naousa" },
                    new City { ID = 202, Name = "Chryso" },
                    new City { ID = 203, Name = "Nea Zichni" },
                    new City { ID = 204, Name = "Sidirokastro" },
                    new City { ID = 205, Name = "Rodolivos" }
                } },
                new Region{ID=5, RegionName="Eastern Macedonia and Thrace", Cities = new List<City>(){
                    new City { ID = 206, Name = "Alexandroupoli"},
                    new City { ID = 207, Name = "Xanthi"},
                    new City { ID = 208, Name = "Kavala"},
                    new City { ID = 209, Name = "Komotini"},
                    new City { ID = 210, Name = "Drama"},
                    new City { ID = 211, Name = "Orestiada"},
                    new City { ID = 212, Name = "Didymoteicho"},
                    new City { ID = 213, Name = "Chrysoupoli" },
                    new City { ID = 214, Name = "Feres" },
                    new City { ID = 215, Name = "Soufli" },
                    new City { ID = 216, Name = "Kimmeria" },
                    new City { ID = 217, Name = "Prosotsani" },
                    new City { ID = 218, Name = "Nea Peramos" },
                    new City { ID = 219, Name = "Krinides" },
                    new City { ID = 220, Name = "Sapes" },
                    new City { ID = 221, Name = "Thasos" },
                    new City { ID = 222, Name = "Agios Athanasios" },
                    new City { ID = 223, Name = "Kalampaki" },
                    new City { ID = 224, Name = "Nea Vyssa" },
                    new City { ID = 225, Name = "Choristi" },
                    new City { ID = 226, Name = "Iasmos" },
                    new City { ID = 227, Name = "Kato Nevrokopi" },
                    new City { ID = 228, Name = "Genisea" },
                    new City { ID = 229, Name = "Eleftheroupoli" },
                    new City { ID = 230, Name = "Fillyra" },
                    new City { ID = 231, Name = "Evlalo" },
                    new City { ID = 232, Name = "Sminthi" },
                    new City { ID = 233, Name = "Samothraki" },
                    new City { ID = 234, Name = "Paranesti" }
                } },
                new Region{ID=6, RegionName="Epirus", Cities = new List<City>(){
                    new City { ID = 235, Name = "Ioannina"},
                    new City { ID = 236, Name = "Preveza"},
                    new City { ID = 237, Name = "Anatoli"},
                    new City { ID = 238, Name = "Filippiada"},
                    new City { ID = 239, Name = "Katsikas"},
                    new City { ID = 240, Name = "Konitsa"},
                    new City { ID = 241, Name = "Filiates" },
                    new City { ID = 242, Name = "Metsovo" },
                    new City { ID = 243, Name = "Paramythia" },
                    new City { ID = 244, Name = "Arta" },
                    new City { ID = 245, Name = "Igoumenitsa" },
                    new City { ID = 246, Name = "Eleousa" },
                    new City { ID = 247, Name = "Kanalaki" },
                    new City { ID = 248, Name = "Peta" },
                    new City { ID = 249, Name = "Kalpaki" },
                    new City { ID = 250, Name = "Pramanta" },
                    new City { ID = 251, Name = "Agia Kyriaki" },
                    new City { ID = 252, Name = "Vourgareli" },
                    new City { ID = 253, Name = "Asprangeloi" },
                    new City { ID = 254, Name = "Ano Kalentini" }
                } },
                new Region{ID=7, RegionName="Ionian Islands", Cities = new List<City>(){
                    new City { ID = 255, Name = "Kerkyra"},
                    new City { ID = 256, Name = "Argostoli"},
                    new City { ID = 257, Name = "Lixouri"},
                    new City { ID = 258, Name = "Lefkimmi"},
                    new City { ID = 259, Name = "Zakynthos"},
                    new City { ID = 260, Name = "Lefkada"},
                    new City { ID = 261, Name = "Gaios"},
                    new City { ID = 262, Name = "Ithaki"}
                } },
                new Region{ID=8, RegionName="North Aegean", Cities = new List<City>(){
                    new City { ID = 263, Name = "Mytilini"},
                    new City { ID = 264, Name = "Chios"},
                    new City { ID = 265, Name = "Neo Karlovasi"},
                    new City { ID = 266, Name = "Myrina"},
                    new City { ID = 267, Name = "Vrontados"},
                    new City { ID = 268, Name = "Plomari"},
                    new City { ID = 269, Name = "Agios Kirykos"},
                    new City { ID = 270, Name = "Samos"},
                    new City { ID = 271, Name = "Oinousses"},
                    new City { ID = 272, Name = "Fournoi"},
                    new City { ID = 273, Name = "Psara"},
                    new City { ID = 274, Name = "Agios Efstratios"}
                } },
                new Region{ID=9, RegionName="Peloponnese", Cities = new List<City>(){
                    new City { ID = 275, Name = "Kalamata"},
                    new City { ID = 276, Name = "Tripoli"},
                    new City { ID = 277, Name = "Korinthos"},
                    new City { ID = 278, Name = "Sparti"},
                    new City { ID = 279, Name = "Nafplio"},
                    new City { ID = 280, Name = "Kiato"},
                    new City { ID = 281, Name = "Messini"},
                    new City { ID = 282, Name = "Filiatra"},
                    new City { ID = 283, Name = "Megalopoli" },
                    new City { ID = 284, Name = "Xylokastro" },
                    new City { ID = 285, Name = "Kyparissia" },
                    new City { ID = 286, Name = "Gargalianoi" },
                    new City { ID = 287, Name = "Zevgolatio" },
                    new City { ID = 288, Name = "Gytheio" },
                    new City { ID = 289, Name = "Kranidi" },
                    new City { ID = 290, Name = "Nemea" },
                    new City { ID = 291, Name = "Leonidio" },
                    new City { ID = 292, Name = "Vrachati" },
                    new City { ID = 293, Name = "Skala" },
                    new City { ID = 294, Name = "Nea Kios" },
                    new City { ID = 295, Name = "Molaoi" },
                    new City { ID = 296, Name = "Pylos" },
                    new City { ID = 297, Name = "Argos" },
                    new City { ID = 298, Name = "Zevgolatio" },
                    new City { ID = 299, Name = "Meligalas" },
                    new City { ID = 300, Name = "Loutraki" },
                    new City { ID = 301, Name = "Kardamyli" },
                    new City { ID = 302, Name = "Elafonisos" },
                    new City { ID = 303, Name = "Asklipieio" },
                    new City { ID = 304, Name = "Dimitsana" }
                } },
                new Region{ID=10, RegionName="South Aegean", Cities = new List<City>(){
                    new City { ID = 305, Name = "Rodos"},
                    new City { ID = 306, Name = "Kos"},
                    new City { ID = 307, Name = "Kalymnos"},
                    new City { ID = 308, Name = "Ermoupoli"},
                    new City { ID = 309, Name = "Archangelos"},
                    new City { ID = 310, Name = "Kremasti"},
                    new City { ID = 311, Name = "Tinos"},
                    new City { ID = 312, Name = "Paros"},
                    new City { ID = 313, Name = "Mykonos"},
                    new City { ID = 314, Name = "Karpathos"},
                    new City { ID = 315, Name = "Agia Marina" },
                    new City { ID = 316, Name = "Fira" },
                    new City { ID = 317, Name = "Andros" },
                    new City { ID = 318, Name = "Naxos" },
                    new City { ID = 319, Name = "Patmos" },
                    new City { ID = 320, Name = "Leipsoi" },
                    new City { ID = 321, Name = "Megisti" },
                    new City { ID = 322, Name = "Ano Syros" },
                    new City { ID = 323, Name = "Symi" },
                    new City { ID = 324, Name = "Apollonia" },
                    new City { ID = 325, Name = "Folegandros" },
                    new City { ID = 326, Name = "Mandraki" },
                    new City { ID = 327, Name = "Antiparos" },
                    new City { ID = 328, Name = "Serifos" },
                    new City { ID = 329, Name = "Ios" },
                    new City { ID = 330, Name = "Kimolos" },
                    new City { ID = 331, Name = "Fry" },
                    new City { ID = 332, Name = "Kythnos" },
                    new City { ID = 333, Name = "Ioulida" },
                    new City { ID = 334, Name = "Chalki" },
                    new City { ID = 335, Name = "Megalo Chorio" },
                    new City { ID = 336, Name = "Astypalaia" },
                    new City { ID = 337, Name = "Amorgos" },
                    new City { ID = 338, Name = "Milos" },
                    new City { ID = 339, Name = "Megalo Chorio" },
                    new City { ID = 340, Name = "Anafi" },
                    new City { ID = 341, Name = "Sikinos" }
                } },
                new Region{ID=11, RegionName="Thessaly", Cities = new List<City>(){
                    new City { ID = 342, Name = "Larisa"},
                    new City { ID = 343, Name = "Volos"},
                    new City { ID = 344, Name = "Trikala"},
                    new City { ID = 345, Name = "Karditsa"},
                    new City { ID = 346, Name = "Tyrnavos"},
                    new City { ID = 347, Name = "Farsala"},
                    new City { ID = 348, Name = "Kalampaka"},
                    new City { ID = 349, Name = "Almyros"},
                    new City { ID = 350, Name = "Giannouli"},
                    new City { ID = 351, Name = "Elassona"},
                    new City { ID = 352, Name = "Agria"},
                    new City { ID = 353, Name = "Nea Anchialos"},
                    new City { ID = 354, Name = "Skiathos"},
                    new City { ID = 355, Name = "Velestino"},
                    new City { ID = 356, Name = "Mouzaki"},
                    new City { ID = 357, Name = "Agia"},
                    new City { ID = 358, Name = "Palamas"},
                    new City { ID = 359, Name = "Sofades"},
                    new City { ID = 360, Name = "Pyli"},
                    new City { ID = 361, Name = "Farkadona"},
                    new City { ID = 362, Name = "Nikaia"},
                    new City { ID = 363, Name = "Zagora"},
                    new City { ID = 364, Name = "Skopelos"},
                    new City { ID = 365, Name = "Argalasti"},
                    new City { ID = 366, Name = "Makrychori"},
                    new City { ID = 367, Name = "Morfovouni"},
                    new City { ID = 368, Name = "Alonnisos"},
                    new City { ID = 369, Name = "Anthiro"}
                } },
                new Region{ID=12, RegionName="Western Greece", Cities = new List<City>(){
                    new City { ID = 370, Name = "Patra"},
                    new City { ID = 371, Name = "Agrinio" },
                    new City { ID = 372, Name = "Pyrgos" },
                    new City { ID = 373, Name = "Nafpaktos" },
                    new City { ID = 374, Name = "Kato Achaia" },
                    new City { ID = 375, Name = "Vonitsa" },
                    new City { ID = 376, Name = "Aitoliko" },
                    new City { ID = 377, Name = "Andravida" },
                    new City { ID = 378, Name = "Amfilochia" },
                    new City { ID = 379, Name = "Vartholomio" },
                    new City { ID = 380, Name = "Zacharo" },
                    new City { ID = 381, Name = "Panaitolio" },
                    new City { ID = 382, Name = "Katochi" },
                    new City { ID = 383, Name = "Neochori" },
                    new City { ID = 384, Name = "Lechaina" },
                    new City { ID = 385, Name = "Astakos" },
                    new City { ID = 386, Name = "Krestena" },
                    new City { ID = 387, Name = "Thermo" },
                    new City { ID = 388, Name = "Kalavryta" },
                    new City { ID = 389, Name = "Chalandritsa" },
                    new City { ID = 390, Name = "Aigio" },
                    new City { ID = 391, Name = "Gastouni" },
                    new City { ID = 392, Name = "Amaliada" },
                    new City { ID = 393, Name = "Archaia Olympia" },
                    new City { ID = 394, Name = "Mesolongi" }
                } },
                new Region{ID=13, RegionName="Western Macedonia", Cities = new List<City>(){
                    new City { ID = 395, Name = "Kozani" },
                    new City { ID = 396, Name = "Kastoria" },
                    new City { ID = 397, Name = "Argos Orestiko" },
                    new City { ID = 398, Name = "Siatista" },
                    new City { ID = 399, Name = "Amyntaio" },
                    new City { ID = 400, Name = "Velventos" },
                    new City { ID = 401, Name = "Maniakoi" },
                    new City { ID = 402, Name = "Florina" },
                    new City { ID = 403, Name = "Ptolemaida" },
                    new City { ID = 404, Name = "Grevena" },
                    new City { ID = 405, Name = "Servia" },
                    new City { ID = 406, Name = "Deskati" },
                    new City { ID = 407, Name = "Laimos" },
                    new City { ID = 408, Name = "Nestorio" }
                } }
                } },
                new Country{ID=2, CountryName="Albania", CountryCode="AL"},
                new Country{ID=3, CountryName="Bulgaria", CountryCode="BG"},
                new Country{ID=4, CountryName="North Macedonia", CountryCode="MK"}
            };

            countries.ForEach(c => context.Countries.AddOrUpdate(c));
            context.SaveChanges();

            List<TelephoneNumber> telephoneNumbers = new List<TelephoneNumber>
            {
                new TelephoneNumber{ ID=1, Mobile="6944444444", Telephone1="2104444444", Telephone2="2101111111"},
                new TelephoneNumber{ ID=2, Mobile="6948888888", Telephone1="2108888888", Telephone2="2108888888"},
                new TelephoneNumber{ ID=3, Mobile="6947777777", Telephone1="2107777777", Telephone2="2107777777"},
                new TelephoneNumber{ ID=4, Mobile="6946666666", Telephone1="2106666666", Telephone2="2106666666"},
                new TelephoneNumber{ ID=5, Mobile="6945555555", Telephone1="2105555555", Telephone2="2105555555"},
                new TelephoneNumber{ ID=6, Mobile="6943333333", Telephone1="2103333333", Telephone2="2103333333"},
            };
            telephoneNumbers.ForEach(t => context.TelephoneNumbers.AddOrUpdate(t));
            context.SaveChanges();

            List<Address> addresses = new List<Address>
            {
                new Address{ID=1, CountryID=1, RegionID=1, CityID = 48, Street="Ippokratous 15", PostalCode="18755", Details="First Floor"},
                new Address{ID=2, CountryID=1, RegionID=1, CityID = 48, Street="Fokionos 11", PostalCode="18756", Details="Second Floor"},
                new Address{ID=3, CountryID=1, RegionID=3, CityID = 112, Street="Eratous 3", PostalCode="74133", Details="Third Floor"},
                new Address{ID=4, CountryID=1, RegionID=9, CityID = 276, Street="Kariatidon 4", PostalCode="22100", Details="Ground Floor"},
                new Address{ID=5, CountryID=1, RegionID=11, CityID = 343, Street="Ilidos 21", PostalCode="38222", Details="First Floor"},
                new Address{ID=6, CountryID=1, RegionID=1, CityID = 3, Street="Epidavrou 3", PostalCode="12134", Details="Third Floor"}
            };
            addresses.ForEach(a => context.Addresses.AddOrUpdate(a));
            context.SaveChanges();

            List<Product> products = new List<Product>
            {
                /*1h suntagh ulika*/
                new Product{ID=1, ProductName="Chicken", Description="Chiken 1 kgr ", Price=8m,ImagePath="~/Content/img/Icons/chicken-whole.png"},
                new Product{ID=2, ProductName="Olive Oil", Description="Olive Oil 1 lt ", Price=10m,ImagePath="~/Content/img/Icons/cooking-oil.png"},
                new Product{ID=3, ProductName="Flour", Description="Flour 1 kgr ", Price=3m,ImagePath="~/Content/img/Icons/flour(bread-flour).png"},
                new Product{ID=4, ProductName="Salt", Description="Salt 100 gr ", Price=1m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                new Product{ID=5, ProductName="Pepper", Description="100 gr Pepper", Price=1m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                /*2h suntagh ulika*/
                new Product{ID=6, ProductName="Baking Powder", Description="Baking Powder 100 gr ", Price=1m,ImagePath="~/Content/img/Icons/baking-powder.png"},
                new Product{ID=7, ProductName="Sriracha", Description="Sriracha 250 ml", Price=3m,ImagePath="~/Content/img/Icons/mustard.png"},
                new Product{ID=8, ProductName="Honey", Description="Honey 500 ml", Price=10m,ImagePath="~/Content/img/Icons/honey-spoon.png"},
                new Product{ID=9, ProductName="Butter", Description="Butter 250 gr", Price=4m,ImagePath="~/Content/img/Icons/butter.png"},
                new Product{ID=10, ProductName="Cornstarch", Description="Cornstarch 1 kgr", Price=5m,ImagePath="~/Content/img/Icons/cornstarch(rice).png"},
                new Product{ID=11, ProductName="Lime", Description="Lime Juice 1 lt", Price=3.5m,ImagePath="~/Content/img/Icons/lemon.png"},
                /*3h suntagh ulika*/
                new Product{ID=12, ProductName="Pasta", Description="Penne Pasta 200gr", Price=0.9m,ImagePath="~/Content/img/Icons/pasta-spaghetti.png"},
                new Product{ID=13, ProductName="Zucchini", Description="Zucchini 1 kgr", Price=6.9m,ImagePath="~/Content/img/Icons/zucchini(kolokithaki).png"},
                new Product{ID=14, ProductName="Spinach", Description="Spinach 1 kgr", Price=2.4m,ImagePath="~/Content/img/Icons/spinach.png"},
                new Product{ID=15, ProductName="Kale", Description="Kale 1 kgr", Price=0.9m,ImagePath="~/Content/img/Icons/kale(laxanida).png"},
                new Product{ID=16, ProductName="Tomatoes", Description="Tomatoes 1 kgr", Price=3.1m,ImagePath="~/Content/img/Icons/tomato-sauce.png"},
                new Product{ID=17, ProductName="Cheese", Description="Goat Cheese 500 gr", Price=10m,ImagePath="~/Content/img/Icons/cheddar-cheese.png"},
                /*4h suntagh ulika*/
                new Product{ID=18, ProductName="Garlic", Description="Garlic Powder 100 gr", Price=0.8m,ImagePath="~/Content/img/Icons/garlic.png"},
                new Product{ID=19, ProductName="Cumin", Description="Cumin 100 gr", Price=0.7m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                new Product{ID=20, ProductName="Turmeric", Description="Turmeric 100 gr", Price=1m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                new Product{ID=21, ProductName="Cinnamon", Description="Cinnamon 100 gr", Price=1.3m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                new Product{ID=22, ProductName="Paprika", Description="Paprika 100 gr", Price=1.4m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                new Product{ID=23, ProductName="Ground Allspice", Description="Ground Allspice 100 gr", Price=1.4m,ImagePath="~/Content/img/Icons/seasoning-set.png"},
                new Product{ID=24, ProductName="Onion", Description="Onion 1 kgr", Price=2.5m,ImagePath="~/Content/img/Icons/onion-yellow.png"},
                new Product{ID=25, ProductName="Lemon", Description="Lemon Juice 500 ml", Price=4m,ImagePath="~/Content/img/Icons/lemon.png"},
                /*5h suntagh*/
                new Product{ID=26, ProductName="Pork", Description="Pork 1 kgr", Price=15m,ImagePath="~/Content/img/Icons/pork-chop.png"},
                new Product{ID=27, ProductName="Beer", Description="Beer 250 ml", Price=1m,ImagePath="~/Content/img/Icons/beer.png"},
                new Product{ID=28, ProductName="Barbecue", Description="Barbecue sauce 250 ml", Price=4.9m,ImagePath="~/Content/img/Icons/mustard.png"},
                new Product{ID=29, ProductName="Buns", Description="Hamburger Buns 250 gr", Price=3.2m,ImagePath="~/Content/img/Icons/bun.png"},
                ///////////////////////
                new Product{ID=30, ProductName="Chicken Breast", Description="Chicken Breast", Price=2.2m,ImagePath="~/Content/img/Icons/chicken-whole.png"},
                new Product{ID=31, ProductName="Chicken Thigh", Description="Chicken Thigh", Price=2.8m,ImagePath="~/Content/img/Icons/chicken-whole.png"},
                /*6h syntagh - mono nea ylika*/
                new Product{ID=32,ProductName="Pork Loin Chop", Description="Pork Chop 150gr",Price=0.90m,ImagePath="~/Content/img/Icons/pork-chop.png"},
                new Product{ID=33,ProductName="Soy Sauce", Description="Soy sauce 250ml",Price=3.5m,ImagePath="~/Content/img/Icons/soy-sauce.png"},
                new Product{ID=34,ProductName="Mustard", Description="Dejon Mustard 250ml",Price=1.85m,ImagePath="~/Content/img/Icons/mustard.png"},
                /*7h syntagh*/
                new Product{ID=35,ProductName="Pork Tenderloin", Description="Pork Tenderloin 200gr",Price=1.50m,ImagePath="~/Content/img/Icons/pork-chop.png"},
                new Product{ID=36,ProductName="Milk", Description="Milk 1L",Price=1.50m,ImagePath="~/Content/img/Icons/milk-non-dairy.png"},
                /*10h syntagh*/
                new Product{ID=37,ProductName="Kechup", Description="Kechup 500ml",Price=2.40m,ImagePath="~/Content/img/Icons/mustard.png"},
                new Product{ID=38,ProductName="Hot Sauce", Description="Hot Sauce 500ml",Price=2.10m,ImagePath="~/Content/img/Icons/mustard.png"},
                new Product{ID=39,ProductName="Chicken Broth", Description="Chicken Broth 350ml",Price=1.90m,ImagePath="~/Content/img/Icons/balsamic-vinegar(bottle).png" },
                new Product{ID=40,ProductName="Parmesan Cheese", Description="Parmesan Cheese 350gr",Price=3m ,ImagePath="~/Content/img/Icons/cheddar-cheese.png"},
                /*12h syntagh*/
                new Product{ID=41,ProductName="Water", Description="Water Bottle 1L",Price=1m,ImagePath="~/Content/img/Icons/water.png" },
                new Product{ID=42,ProductName="Carrots", Description="Carrots 1kg",Price=2.5m,ImagePath="~/Content/img/Icons/carrot.png" },
                new Product{ID=43,ProductName="Celery", Description="Celery 0.5kg",Price=1.5m,ImagePath="~/Content/img/Icons/celery.png" },
                new Product{ID=44,ProductName="Rice", Description="Rice 500kg",Price=2m,ImagePath="~/Content/img/Icons/rice.png" },
                new Product{ID=45,ProductName="Eggs", Description="Eggs 6-pack",Price=2.5m,ImagePath="~/Content/img/Icons/eggs.png" },

                /*Subscription*/
                new Product{ID=46,ProductName="Subscription", Description="Yearly subscription as a premium user",Price=25,ImagePath="~/Content/img/Icons/subscribe.png" },

                /*13h syntagh*/
                new Product{ID=47,ProductName="Corn Flakes", Description="Corn Bran Flakes 1kg",Price=4.3m,ImagePath="~/Content/img/Icons/rice(cornstarch).png" },
                /*14h syntagh*/
                new Product{ID=48,ProductName="Sweet only Flour", Description="Sweet Only Flour",Price=2m,ImagePath="~/Content/img/Icons/flour(all-purposes).png" },
                new Product{ID=49,ProductName="Sweet Shortening", Description="Shortening 500kg",Price=11.90m,ImagePath="~/Content/img/Icons/flour(whole-wheat).png" },
                new Product{ID=50,ProductName="Nutmeg", Description="McFurley Ground Nutmeg 300g",Price=11.90m,ImagePath="~/Content/img/Icons/coconut-milk(vegan).png" },
                new Product{ID=51,ProductName="Apple", Description="Fresh Yard Apples 1kg",Price=2m,ImagePath="~/Content/img/Icons/apple.png" },
                new Product{ID=52,ProductName="Sugar", Description="Brown Sugar",Price=2m,ImagePath="~/Content/img/Icons/sugar-cubes.png" },
                /*15h syntagh*/
                new Product{ID=53,ProductName="Baking Chocolate", Description="Chocolate 5Bars-Packet",Price=6m,ImagePath="~/Content/img/Icons/chocolate-dark.png" },
                new Product{ID=54,ProductName="Vanilla", Description="Vanilla Flavouring",Price=1m,ImagePath="~/Content/img/Icons/vanilla-bean.png" },
                new Product{ID=55,ProductName="Cocoa Powder", Description="Hershay's Dark Cocoa 500g",Price=4.2m,ImagePath="~/Content/img/Icons/chocolate-dark.png" },
                new Product{ID=56,ProductName="Espresso Powder", Description="Espresso Powder 10sticks",Price=2.7m,ImagePath="~/Content/img/Icons/cocoa-powder(brown jar).png"},
                new Product{ID=57,ProductName="Chive", Description="Fresh Shives 1kg",Price=1.4m,ImagePath="~/Content/img/Icons/spinach.png" }
            };
            products.ForEach(p => context.Products.AddOrUpdate(p));
            context.SaveChanges();

            List<IngredientCategory> ingredientCategories = new List<IngredientCategory>
            {
                new IngredientCategory{ID=1,Description="Vegetables"},
                new IngredientCategory{ID=2,Description="Fruit"},
                new IngredientCategory{ID=3,Description="Dairy Products"},
                new IngredientCategory{ID=4,Description="Meat"},
                new IngredientCategory{ID=5,Description="Fish"},
                new IngredientCategory{ID=6,Description="Cheese"},
                new IngredientCategory{ID=7,Description="Cold Cuts"},
                new IngredientCategory{ID=8,Description="Spices"},
                new IngredientCategory{ID=9,Description="Legumes"},
                new IngredientCategory{ID=10,Description="Pasta"},
                new IngredientCategory{ID=11,Description="Cooking Fats & Oils"},
                new IngredientCategory{ID=12,Description="Flour"},
                new IngredientCategory{ID=13,Description="Sauce"},
                new IngredientCategory{ID=14,Description="Bread"},
                new IngredientCategory{ID=15,Description="Soft Drinks Water Juices"},
                new IngredientCategory{ID=16,Description="Sweetenings"},
            };

            ingredientCategories.ForEach(i => context.IngredientCategories.AddOrUpdate(i));
            context.SaveChanges();

            List<Ingredient> ingredients = new List<Ingredient>
            {
            /*1h suntagh*/
            new Ingredient{ID=1, IngredientCategoryID=4, ProductID = 30 },
            new Ingredient{ID=2, IngredientCategoryID=12, ProductID=2 },
            new Ingredient{ID=3, IngredientCategoryID=13, ProductID=3 },
            new Ingredient{ID=4, IngredientCategoryID=8, ProductID = 4 },
            new Ingredient{ID=5, IngredientCategoryID=8, ProductID = 5 },
            new Ingredient{ID=6, IngredientCategoryID=12, ProductID = 2 },
            /*2h suntagh*/
            new Ingredient{ID=7, IngredientCategoryID=4, ProductID = 31 },
            new Ingredient{ID=8, IngredientCategoryID=8, ProductID = 6 },
            new Ingredient{ID=9, IngredientCategoryID=8, ProductID = 4 },
            new Ingredient{ID=10, IngredientCategoryID=14, ProductID = 7 },
            new Ingredient{ID=11, IngredientCategoryID=11, ProductID = 8 },
            new Ingredient{ID=12, IngredientCategoryID=3, ProductID = 9 },
            new Ingredient{ID=13, IngredientCategoryID=8, ProductID = 10 },
            new Ingredient{ID=14, IngredientCategoryID=11, ProductID = 11 },
            /*3h suntagh*/
            new Ingredient{ID=15, IngredientCategoryID=10, ProductID = 12 },
            new Ingredient{ID=16,IngredientCategoryID=1, ProductID = 13 },
            new Ingredient{ID=17, IngredientCategoryID=1, ProductID = 14 },
            new Ingredient{ID=18, IngredientCategoryID=1, ProductID = 15 },
            new Ingredient{ID=19, IngredientCategoryID=12, ProductID = 2 },
            new Ingredient{ID=20, IngredientCategoryID=1, ProductID = 16 },
            new Ingredient{ID=21, IngredientCategoryID=6, ProductID = 17 },
            new Ingredient{ID=22, IngredientCategoryID=8, ProductID = 4 },
            new Ingredient{ID=23, IngredientCategoryID=8, ProductID = 5 },
            /*4h suntagh*/
            new Ingredient{ID=24, IngredientCategoryID=1, ProductID = 18 },
            new Ingredient{ID=25, IngredientCategoryID=8, ProductID = 4 },
            new Ingredient{ID=26, IngredientCategoryID=8, ProductID = 5 },
            new Ingredient{ID=27, IngredientCategoryID=8, ProductID = 19 },
            new Ingredient{ID=28, IngredientCategoryID=8, ProductID = 20 },
            new Ingredient{ID=29, IngredientCategoryID=8, ProductID = 21 },
            new Ingredient{ID=30, IngredientCategoryID=8, ProductID = 22 },
            new Ingredient{ID=31, IngredientCategoryID=8, ProductID = 23 },
            new Ingredient{ID=32, IngredientCategoryID=4, ProductID = 31 },
            new Ingredient{ID=33, IngredientCategoryID=1, ProductID = 24 },
            new Ingredient{ID=34, IngredientCategoryID=12, ProductID = 2 },
            new Ingredient{ID=35, IngredientCategoryID=11, ProductID = 25 },
            /*5h suntagh*/
            new Ingredient{ID=36, IngredientCategoryID=4, ProductID = 26 },
            new Ingredient{ID=37, IngredientCategoryID=11, ProductID = 27 },
            new Ingredient{ID=38, IngredientCategoryID=14, ProductID = 28 },
            new Ingredient{ID=39, IngredientCategoryID=15, ProductID = 29 },
            /*6h syntagh*/
            new Ingredient{ID=40, IngredientCategoryID=4, ProductID = 32 },
            new Ingredient{ID=41, IngredientCategoryID=13, ProductID = 33 },
            new Ingredient{ID=42, IngredientCategoryID=13, ProductID = 34 },
            /*7h syntagh*/
            new Ingredient{ID=43, IngredientCategoryID=4, ProductID = 35 },
            /*10h syntagh*/
            new Ingredient{ID=44, IngredientCategoryID=3, ProductID = 36 },
            new Ingredient{ID=45, IngredientCategoryID=13, ProductID = 37 },
            new Ingredient{ID=46, IngredientCategoryID=13, ProductID = 38 },
            new Ingredient{ID=47, IngredientCategoryID=11, ProductID = 39 },
            new Ingredient{ID=48, IngredientCategoryID=6, ProductID = 40 },
            /*12h syntagh*/
            new Ingredient{ID=49, IngredientCategoryID=15, ProductID = 41 },
            new Ingredient{ID=50, IngredientCategoryID=1, ProductID = 42 },
            new Ingredient{ID=51, IngredientCategoryID=1, ProductID = 43 },
            new Ingredient{ID=52, IngredientCategoryID=9, ProductID = 44 },
            new Ingredient{ID=53, IngredientCategoryID=3, ProductID = 45 },
            /*13h syntagh*/
            new Ingredient{ID=54, IngredientCategoryID=1, ProductID = 57 }, //teleutaia 
            new Ingredient{ID=55, IngredientCategoryID=9, ProductID = 47 },
            /*14h syntagh*/
            new Ingredient{ID=56, IngredientCategoryID=12, ProductID = 48 },
            new Ingredient{ID=57, IngredientCategoryID=11, ProductID = 49 },
            new Ingredient{ID=58, IngredientCategoryID=9, ProductID = 50 },
            new Ingredient{ID=59, IngredientCategoryID=2, ProductID = 51 },
            new Ingredient{ID=60, IngredientCategoryID=16, ProductID = 52 },
            /*15h syntagh*/
            new Ingredient{ID=61, IngredientCategoryID=16, ProductID = 53 },
            new Ingredient{ID=62, IngredientCategoryID=16, ProductID = 54 },
            new Ingredient{ID=63, IngredientCategoryID=16, ProductID = 55 },
            new Ingredient{ID=64, IngredientCategoryID=15, ProductID = 56 },
            /*Teleutaio productID=57----line245*/
            /*Epomenh kataxwrish prepei nanai productID=58*/
            };

            ingredients.ForEach(i => context.Ingredients.AddOrUpdate(i/*=>i.ProductName,p*/));
            context.SaveChanges();

            List<RecipeCategory> recipeCategories = new List<RecipeCategory>
            {
                new RecipeCategory {ID=1, Descreption="Appetizer"},
                new RecipeCategory {ID=2, Descreption="Main Meal"},
                new RecipeCategory {ID=3, Descreption="Desert"},
                new RecipeCategory {ID=4, Descreption="Breakfast"},
            };

            recipeCategories.ForEach(r => context.RecipeCategories.AddOrUpdate(r));
            context.SaveChanges();

            List<Customer> customers = new List<Customer>
            {
                new Customer{ ID=1, FirstName="Stauros", LastName="Giotopoloulos", DateOfBirth=DateTime.Parse("2000-01-01"), AddressID=2, TelephoneNumberID=2},
                new Customer{ ID=2, FirstName="Kostas", LastName="Papadopoulos", DateOfBirth=DateTime.Parse(("2001-11-11")), AddressID=3, TelephoneNumberID=3},
                new Customer{ ID=3, FirstName="katerina", LastName="Kalapotharakou", DateOfBirth=DateTime.Parse(("2002-12-12")), AddressID=4, TelephoneNumberID=4},
                new Customer{ ID=4, FirstName="Eleni", LastName="Kritikaki", DateOfBirth=DateTime.Parse(("2004-02-18")), AddressID=5, TelephoneNumberID=5},
                new Customer{ ID=5, FirstName="Giota", LastName="Dimitraki", DateOfBirth=DateTime.Parse(("1999-05-05")), AddressID=6, TelephoneNumberID=6},
                new Customer{ ID=6, FirstName="Anna", LastName="Kalesiorh", DateOfBirth=DateTime.Parse(("1998-06-06")), AddressID=1, TelephoneNumberID=1},
                new Customer{ ID=7, FirstName="Giorgos", LastName="Athinaios", DateOfBirth=DateTime.Parse(("1997-07-07")), AddressID=2, TelephoneNumberID=2},
                new Customer{ ID=8, FirstName="Panagioths", LastName="Kritikopoulos", DateOfBirth=DateTime.Parse(("1996-08-08")), AddressID=1, TelephoneNumberID=1},
            };

            customers.ForEach(c => context.Customers.AddOrUpdate(c));
            context.SaveChanges();

            List<Recipe> recipes = new List<Recipe>
            {
                new Recipe{ID=1, RecipeName="Air Fryer Chicken Nuggets", ActiveTime="5 min", TotalTime="23 min", DifficultyLevel=Enums.DifficultyLevel.Simple,
                    Instructions="1.In a medium-sized bowl, toss diced chicken breasts in olive oil. Add salt and pepper to taste.xxx" +
                    "2.Place chicken in an air fryer and cook at 200°C for 15 minutes, flipping halfway through.xxx" +
                    "3.Transfer chicken to a bowl.Spray with oil and generously coat in flour or panko breadcrumbs.xxx" +
                    "4.Return nuggets to air fryer and cook, about 8 minutes, tossing occasionally to ensure they’re fully browned.xxx" +
                    "5.Serve with your favorite dipping sauce.Enjoy!", RecipeCategoryID=1, VideoUrl = "https://www.youtube.com/embed/uCIrc2HQETM",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/air-fryer-chicken-nuggets.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=1,IngredientID=1, Quantity=3, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=1,IngredientID=2, Quantity= 3, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=1,IngredientID=3, Quantity=0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=1,IngredientID=4},
                                new RecipeIngredient{RecipeID=1,IngredientID=5},
                                new RecipeIngredient{RecipeID=1,IngredientID=6}

                    } },

                new Recipe{ID=2, RecipeName="Honey Sriracha Drumsticks", ActiveTime="15 min", TotalTime="45 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. Set drumsticks on a large sheet of foil. Pat dry with paper towels.xxx" +
                    "2. Heat oven to 220°C. Prepare baking sheet by lining with foil, then parchment paper.xxx" +
                    "3. In a large zip-top bag, add half of the drumsticks, 1 teaspoon baking powder and 1/2 teaspoon salt. Shake bag to coat evenly.xxx" +
                    "4. Lay the drumsticks on baking sheet skin side up.xxx" +
                    "5. Repeat steps 3 and 4 with remaining drumsticks.xxx" +
                    "6. Bake for 45 minutes.xxx" +
                    "7.While chicken is baking, combine sriracha, butter, and honey in a small saucepan over medium heat.xxx" +
                    "8.In a small cup, combine cornstarch with lime juice and 2 tablespoons water.Stir until cornstarch is completely dissolved.xxx" +
                    "9.When butter is melted and the mixture begins to bubble, stir in cornstarch mixture.Cook until thickened, stirring constantly, for 2 to 3 minutes.Set aside.xxx" +
                    "10.Remove wings from oven.Brush each drumstick generously with honey sriracha sauce.Serve immediately.", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/S4qgnusybuo",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/honey-sriracha-drumsticks.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=2,IngredientID=7, Quantity=8},
                                new RecipeIngredient{RecipeID=2,IngredientID=8, Quantity=2, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=2,IngredientID=9, Quantity=1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=2,IngredientID=10, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=2,IngredientID=11, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=2,IngredientID=12, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=2,IngredientID=13, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=2,IngredientID=14, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.tablespoon}
                    } },

                new Recipe{ID=3, RecipeName="Penne Pasta with wilted greens", ActiveTime="5 min", TotalTime="15 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. Cook the penne pasta according to package directions. Reserve ½ cup of pasta water.xxx" +
                    "2. Using a peeler or mandolin, cut zucchini into ribbons lengthwise.xxx" +
                    "3. Heat 2 tablespoons of olive oil over in a large sauté pan. Add the zucchini ribbons.xxx" +
                    "4. Cook for about 3 minutes, then add the spinach and kale.xxx" +
                    "5.Sauté for a couple of minutes or until the greens are wilted.xxx" +
                    "6.Add the cooked pasta, ½ cup of pasta water, the remaining olive oil and sundried tomatoes to the sauté pan.Season with salt and pepper.xxx" +
                    "7.Mix thoroughly and top with crumbled goat cheese. ", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/CBm5NnlxO1Y",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/penne-pasta-with-wilted-greens.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=3,IngredientID=15, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=3,IngredientID=16, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=3,IngredientID=17, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=3,IngredientID=18, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=3,IngredientID=19, Quantity = 4, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=3,IngredientID=20, Quantity = 0.75, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=3,IngredientID=21, Quantity = 115, MeasuringUnit = Enums.MeasuringUnit.gram},
                                new RecipeIngredient{RecipeID=3,IngredientID=22},
                                new RecipeIngredient{RecipeID=3,IngredientID=23}
                    } },

                new Recipe{ID=4, RecipeName="Chicken Shawarma", ActiveTime="10 min", TotalTime="15 min", DifficultyLevel=Enums.DifficultyLevel.Easy,
                    Instructions="1. Heat oven to 260°C and place rack in the middle of the oven.xxx" +
                    "2. Line a baking sheet with aluminum foil.xxx" +
                    "3. In a large bowl, mix all the spices together.xxx" +
                    "4. Add chicken thighs to the spice mix and stir until fully coated.xxx" +
                    "5. Place chicken thighs and sliced onion onto the prepared baking sheet.xxx" +
                    "6. In a small bowl, combine olive oil and lemon juice.xxx" +
                    "7. Bake the chicken for 5 minutes, flip it over and brush half of the olive oil and lemon juice mixture over the chicken.Then, bake for another 5 minutes.Brush with the remaining oil and bake for 3 minutes, or until fully cooked.xxx" +
                    "8. Serve warm with toppings and sauce of choice. ", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/3lxUIeKDgic",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/chicken-shawarma.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=4,IngredientID=24, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=25, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=26, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=27, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=28, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=29, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=30, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=31, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=4,IngredientID=32, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.kg},
                                new RecipeIngredient{RecipeID=4,IngredientID=33, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=4,IngredientID=34, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=4,IngredientID=35, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.piece}
                    } },

                new Recipe{ID=5, RecipeName="Pulled Pork sandwich", ActiveTime="5 min",TotalTime="360 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. Place pork in slow cooker and pour in the can of root beer.xxx" +
                    "2. Cover and cook on low for 6 hours.xxx" +
                    "3.Remove the pork and drain the root beer.Shred the meat and add it back to the slow cooker; pouring and stirring in the bbq sauce. xxx" +
                    "4.Serve on hamburger buns. ", RecipeCategoryID=4, VideoUrl = "https://www.youtube.com/embed/syzKfSZiKEA",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/pulled-pork-sandwich.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=5,IngredientID=36, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.kg},
                                new RecipeIngredient{RecipeID=5,IngredientID=37, Quantity = 340, MeasuringUnit = Enums.MeasuringUnit.gram},
                                new RecipeIngredient{RecipeID=5,IngredientID=38, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.l},
                                new RecipeIngredient{RecipeID=5,IngredientID=39, Quantity = 8, MeasuringUnit = Enums.MeasuringUnit.piece}
                    } },

                new Recipe{ID=6, RecipeName="Juicy Grilled Pork Chops", ActiveTime="5 min",TotalTime="240 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. When you're ready to cook, prepare and preheat the grill, building a ​two-level fire.xxx" +
                    "2.Place the chops on the hottest part of the grill and cook for 1 to 2 minutes.xxx" +
                    "3.Then move the chops to the cooler part of the grill. Cover and grill for 4 minutes. Grill until a meat thermometer registers 145 F to 150 F. xxx" +
                    "4.Let stand 5 to 10 minutes, then serve. ", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/lUKSAIwe7wg",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/juicy-grilled-pork-chops.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=6,IngredientID=40, Quantity = 4, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=6,IngredientID=41, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=6,IngredientID=42, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=6,IngredientID=5, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=6,IngredientID=9, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.tablespoon}
                    } },

                new Recipe{ID=7, RecipeName="Lemon Thyme Pork Tenderloin", ActiveTime="5 min",TotalTime="50 min", DifficultyLevel=Enums.DifficultyLevel.Extreme,
                    Instructions="1. Pierce the tenderloin all over with a fork and place in baking dish .xxx" +
                    "2. Mix remaining ingredients and pour over pork .xxx" +
                    "3.Cover and marinate in the refrigerator for 2 to 24 hours, turning pork once or twice. Or just let the pork marinate at room temperature for 15 minutes. xxx" +
                    "4. When ready to cook, preheat oven to 350 F.xxx" +
                    "5. Place the two tenderloins on a shallow baking pan, at least 2 inches apart.xxx" +
                    "6. Roast for 35 to 40 minutes until pork registers 145 F on a meat thermometer.xxx" +
                    "7. Let stand 5 minutes, then slice to serve. Pork will be light pink in the center.", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/xUl6ECdIy08",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/lemon-thyme-pork-tenderloin.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=7,IngredientID=43, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=7,IngredientID=14, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=7,IngredientID=6, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=7,IngredientID=9, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=7,IngredientID=5, Quantity = 0.2, MeasuringUnit = Enums.MeasuringUnit.teaspoon}
                    } },

                new Recipe{ID=8, RecipeName="Ranch-Marinated Pork Chop", ActiveTime="12 min",TotalTime="44 min", DifficultyLevel=Enums.DifficultyLevel.Easy,
                    Instructions="1. Combine dressing and pork chops in a shallow bowl and turn to coat. Cover and refrigerate for 30 minutes up to 8 hours .xxx" +
                    "2. When ready to cook, prepare and preheat the grill, building a two-level fire .xxx" +
                    "3. Remove the chops from the marinade; discard marinade .xxx" +
                    "4. Place chops on the hottest part of the grill and cook for 1 to 2 minutes .xxx" +
                    "5. When the chops release, turn them and sear on the second side, for 1 to 2 minutes.xxx" +
                    "6. Then move the chops to the cooler part of the grill. Cover and grill for 4 minutes .xxx" +
                    "7. Turn the chops and cover; grill for 4 to 6 minutes longer or until a meat thermometer registers 145 to 150 F .xxx"+
                    "8. Remove chops from grill, place on serving plate, and cover. Let stand 5 to 10 minutes. Serve and enjoy!", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/GwG5vGx3xrk",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/ranch-marinated-pork-chop.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=8,IngredientID=32, Quantity = 4, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=8,IngredientID=35, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=8,IngredientID=2, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=8,IngredientID=4, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.tablespoon}
                    } },

                new Recipe{ID=9, RecipeName="Grilled Parmesan Pork Loin", ActiveTime="5 min",TotalTime="55 min", DifficultyLevel=Enums.DifficultyLevel.Hard,
                    Instructions="1. Preheat the oven to 375 F. xxx" +
                    "2. In a small bowl, combine the olive oil, thyme, chicken broth, salt, and pepper. Roll pork in this mixture, then roll in both types of the Parmesan cheese to coat .xxx" +
                    "3. Place the pork on a roasting pan and sprinkle with any remaining cheese .xxx" +
                    "4. Roast, uncovered, for 40 to 50 minutes until an internal meat thermometer registers at least 145 F .xxx" +
                    "5. Remove pork from the pan, cover, and let stand 10 minutes before slicing to serve .xxx" +
                    "6. Serve and enjoy! .xxx", RecipeCategoryID=1, VideoUrl = "https://www.youtube.com/embed/G14ZTKS-FmY",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/grilled-parmesan-pork-loin.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=9,IngredientID=2, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=9,IngredientID=47, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=9,IngredientID=4, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=9,IngredientID=5, Quantity = 0.1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=9,IngredientID=43, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.kg},
                                new RecipeIngredient{RecipeID=9,IngredientID=48, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.cup}
                    } },

                new Recipe{ID=10, RecipeName="Grilled Pork Baby Back Ribs", ActiveTime="20 min",TotalTime="90 min", DifficultyLevel=Enums.DifficultyLevel.Extreme,
                    Instructions="1. In a large saucepan, sauté garlic. xxx" +
                    "2. Add remaining sauce ingredients and allow to come to a boil. Turn down heat and let simmer for 15 minutes, stirring often .xxx" +
                    "3. While sauce is simmering, combine rub ingredients in a medium mixing bowl. Set aside .xxx" +
                    "4. Remove the sauce from the heat and allow to cool .xxx" +
                    "5. Trim and clean ribs .xxx" +
                    "6. Rub ribs with spices and let then sit for 30 minutes at room temperature .xxx"+
                    "7. Preheat grill.xxx"+
                    "8. Cook over an indirect medium heat for about an hour.xxx"+
                    "9. When the ribs have finished cooking, a knife will pass easily into the meat between the ribs and you can see no or very little pink .xxx"+
                    "10. Serve with the sauce and your favorite barbecue sides and enjoy!", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/vFLEDmNGRIw",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/grilled-pork-baby-back-ribs.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=10,IngredientID=15, Quantity = 6, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=10,IngredientID=45, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=10,IngredientID=4, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=10,IngredientID=42, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=10,IngredientID=46, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=10,IngredientID=41, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=10,IngredientID=2, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=10,IngredientID=30, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.teaspoon}
                    } },

                new Recipe{ID=11, RecipeName="Chicken Mozzarella", ActiveTime="15 min",TotalTime="50 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. Dip the chicken breasts in the milk, then shake off any excess. xxx" +
                    "2. Dredge the chicken in the breadcrumbs .xxx" +
                    "3. Place in a single layer on a large platter and refrigerate for 30 minutes to set the crust .xxx" +
                    "4. Preheat the oven to 375 F. Spray a 9- by 13-inch glass or ceramic baking dish with vegetable oil .xxx" +
                    "5. Heat a large, heavy skillet over medium-high heat. When the skillet is hot, add 1 tablespoon of the olive oil and swirl to coat the bottom of the pan .xxx" +
                    "6. Quickly brown each of the chicken breasts, turning only once. Use the second tablespoon of olive oil for the second batch .xxx"+
                    "7. Arrange the browned chicken in the bottom of the casserole dish, overlapping as little as possible .xxx"+
                    "8. Top with the mozzarella cheese .xxx"+
                    "9. Bake uncovered for 15 to 20 minutes or until the chicken is heated through and cheese is bubbly and slightly golden .xxx"+
                    "10. Let the chicken mozzarella rest 5 minutes before serving.", RecipeCategoryID=2, VideoUrl = "https://www.youtube.com/embed/-pMTMY27j7U",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/mozzarella-chicken.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=11,IngredientID=1, Quantity = 8, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=11,IngredientID=44, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=11,IngredientID=20, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=11,IngredientID=2, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=11,IngredientID=9, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=11,IngredientID=27, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=11,IngredientID=24, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=11,IngredientID=30, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=11,IngredientID=4, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=11,IngredientID=17, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.cup}
                    } },

                new Recipe{ID=12, RecipeName="Chicken Soup Avgolemono", ActiveTime="15 min",TotalTime="120 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. Gather the ingredients. xxx" +
                    "2. Add the chicken, water, carrots, celery stalks, onion, bay leaves, black peppercorns, and salt to a large stockpot. Bring to a rapid boil, lower the heat to medium-low and simmer partially covered for approximately an hour to an hour and a half .xxx" +
                    "3. Remove the chicken and vegetables to a bowl and carefully strain the broth through a fine sieve into a separate large bowl .xxx" +
                    "4. Add the orzo pasta or rice and cook, uncovered, for approximately 10 to 12 minutes until tender .xxx" +
                    "5. While the pasta is cooking, prepare the egg-lemon mixture. Using a whisk, beat the eggs until nice and frothy in a bowl .xxx" +
                    "6. Add the lemon zest and the lemon juice in a steady stream while continuing to whisk .xxx"+
                    "7. When the pasta has finished cooking, turn off the heat. Ladle about 2 cups of broth into a bowl or large measuring cup .xxx"+
                    "8. Slowly add the hot broth to the egg-lemon mixture while continuing to whisk. This will temper the eggs and prevent them from curdling once they are added to the hot broth .xxx"+
                    "9. Stir the egg-lemon mixture into the pot and heat over very low heat for approximately 5 to 10 minutes until heated through. Be careful not to boil the soup once the eggs have been added .xxx"+
                    "10. Adjust your seasoning for salt and pepper.xxx"+
                    "11. Traditionally, this soup is served without the chicken meat or vegetables. You can add them back or serve on the side as you prefer.xxx"+
                    "12. Serve and enjoy!", RecipeCategoryID=1, VideoUrl = "https://www.youtube.com/embed/Az2EOGbaTWU",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/chicken-soup-avgolemono.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=12,IngredientID=1, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.kg},
                                new RecipeIngredient{RecipeID=12,IngredientID=49, Quantity = 12, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=12,IngredientID=50, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=12,IngredientID=51, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=12,IngredientID=33, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=12,IngredientID=5, Quantity = 5, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=12,IngredientID=4, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=12,IngredientID=52, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=12,IngredientID=53, Quantity = 3, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=12,IngredientID=35, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup}
                    } },

                new Recipe{ID=13, RecipeName="Oven Chicken Cordon Bleu", ActiveTime="15 min",TotalTime="30 min", DifficultyLevel=Enums.DifficultyLevel.Moderate,
                    Instructions="1. Heat oven to 375°F. Spray 8-inch square (2 quart) glass baking dish with cooking spray. Between sheets of plastic wrap or waxed paper, flatten each chicken breast to 1/4-inch thickness. xxx" +
                    "2. Spread each chicken breast with 1/2 teaspoon mustard; sprinkle with 1 teaspoon chives. Cut ham and cheese slices to fit chicken. Top each chicken breast with ham and cheese slice. Roll up, tucking ends inside .xxx" +
                    "3. In shallow bowl, combine egg white and water; beat slightly. Place cereal crumbs in shallow dish. Coat chicken rolls with egg white mixture; roll in crumbs. Place in baking dish; sprinkle with paprika .xxx" +
                    "4. Bake 25 to 30 minutes, or until chicken is no longer pink in center .xxx" +
                    "5. Serve and Enjoy! ", RecipeCategoryID=1, VideoUrl = "https://www.youtube.com/embed/ISJNOMtSGoA",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/oven-chicken-cordon-bleu.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=13,IngredientID=1, Quantity = 4, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=13,IngredientID=42, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=13,IngredientID=54, Quantity = 4, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=13,IngredientID=21, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=13,IngredientID=53, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=13,IngredientID=49, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=13,IngredientID=55, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=13,IngredientID=30, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.teaspoon}
                    } },

                new Recipe{ID=14, RecipeName="Sugar-Kissed Apple Pie", ActiveTime="45 min",TotalTime="140 min", DifficultyLevel=Enums.DifficultyLevel.Extreme,
                    Instructions="1. Heat oven to 425°F. In medium bowl, mix 2 cups flour and 1 teaspoon salt. Cut in shortening, using pastry blender (or pulling 2 table knives through ingredients in opposite directions), until particles are size of small peas. Sprinkle with cold water, 1 tablespoon at a time, tossing with fork until all flour is moistened and pastry almost cleans side of bowl (1 to 2 teaspoons more water can be added if necessary). xxx" +
                    "2. Gather pastry into a ball. Divide pastry in half; shape each half into flattened round on lightly floured surface. Wrap flattened rounds of pastry in plastic wrap; refrigerate about 45 minutes or until firm and cold, yet pliable .xxx" +
                    "3. On lightly floured surface, roll 1 round of pastry into circle 2 inches larger than upside-down 9-inch glass pie plate, using floured rolling pin. Fold pastry into fourths; place in pie plate. Unfold and ease into plate, pressing firmly against bottom and side .xxx" +
                    "4. In large bowl, mix 1/2 cup sugar, 1/4 cup flour, the cinnamon, nutmeg and dash of salt. Stir in apples. Spoon into pastry-lined pie plate. Cut butter into small pieces; sprinkle over apples. Trim overhanging edge of bottom pastry 1/2 inch from rim of plate .xxx" +
                    "5. Roll other round of pastry. Fold pastry into fourths and cut slits so steam can escape; place over filling and unfold. Trim overhanging edge of top pastry 1 inch from rim of plate. Fold and roll top edge under lower edge, pressing on rim to seal; flute. Brush top crust with 1 tablespoon water; sprinkle with 1 tablespoon sugar .xxx" +
                    "6. Cover edge with 2- to 3-inch strip of foil to prevent excessive browning; remove foil during last 15 minutes of baking. Bake 40 to 50 minutes or until crust is golden brown and juice begins to bubble through slits in crust. Cool on cooling rack at least 2 hours .xxx"+
                    "7. Serve and Enjoy! ", RecipeCategoryID=3, VideoUrl = "https://www.youtube.com/embed/VFQsDAADPLM",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/sugar-kissed-apple-pie.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=14,IngredientID=56, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=14,IngredientID=4, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=14,IngredientID=57, Quantity = 0.75, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=14,IngredientID=49, Quantity = 6, MeasuringUnit = Enums.MeasuringUnit.tablespoon},
                                new RecipeIngredient{RecipeID=14,IngredientID=60, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=14,IngredientID=29, Quantity = 0.75, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=14,IngredientID=58, Quantity = 0.25, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=14,IngredientID=59, Quantity = 6, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=14,IngredientID=12, Quantity = 2, MeasuringUnit = Enums.MeasuringUnit.tablespoon}
                    } },

                new Recipe{ID=15, RecipeName="Flourless Chocolate Cake", ActiveTime="20 min",TotalTime="120 min", DifficultyLevel=Enums.DifficultyLevel.Hard,
                    Instructions="1. Heat oven to 375°F. Line bottom of 9-inch round cake pan with cooking parchment paper; spray with cooking spray. xxx" +
                    "2. In 2-quart saucepan, melt chocolate and butter over low heat, stirring constantly. Remove from heat; pour into large bowl. Stir in sugar until blended. Stir in eggs, 1 at a time; stir in vanilla. Stir in cocoa and espresso powder until well blended. Pour into pan .xxx" +
                    "3. Bake 26 to 30 minutes or until toothpick inserted in center comes out clean. Cool 10 minutes. Run knife around side of pan to loosen cake. Place cooling rack upside down over cake. Turn upside down carefully so cake is on rack; remove pan. Turn upside down onto another rack, and flip cake right side up. Cool completely, about 1 hour.xxx" +
                    "4. When ready to serve, place cake right side up on serving platter. Using sharp knife, cut into wedges, cleaning knife blade after each cut. Serve with whipping cream. Store loosely covered in refrigerator.xxx" +
                    "5. Serve and dig in! ", RecipeCategoryID=3, VideoUrl = "https://www.youtube.com/embed/YWu9nGIjJAY",
                    ImageUrl = "~/Content/img/recipe/ourRecipes/flourless-chocolate-cake.jpg",
                    RecipeIngredients = new List<RecipeIngredient>(){
                                new RecipeIngredient{RecipeID=15,IngredientID=61, Quantity = 0.34, MeasuringUnit = Enums.MeasuringUnit.kg},
                                new RecipeIngredient{RecipeID=15,IngredientID=12, Quantity = 0.75, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=15,IngredientID=60, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=15,IngredientID=53, Quantity = 6, MeasuringUnit = Enums.MeasuringUnit.piece},
                                new RecipeIngredient{RecipeID=15,IngredientID=62, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon},
                                new RecipeIngredient{RecipeID=15,IngredientID=63, Quantity = 0.5, MeasuringUnit = Enums.MeasuringUnit.cup},
                                new RecipeIngredient{RecipeID=15,IngredientID=64, Quantity = 1, MeasuringUnit = Enums.MeasuringUnit.teaspoon}
                    } },
            };

            recipes.ForEach(r => context.Recipes.AddOrUpdate(r));
            context.SaveChanges();

            List<Order> orders = new List<Order>
            {
                new Order{IsPaid = true, OrderID=1, UserName="k.tsomisi@gmail.com", Total=10m, OrderDate = DateTime.Parse("2019-12-08")},
                new Order{IsPaid = true, OrderID=2, UserName="a.klopas@gmail.com", Total=5m, OrderDate = DateTime.Parse("2020-10-01")},
                new Order{IsPaid = true, OrderID=3, UserName="s.polatsidis@gmail.com", Total=6m, OrderDate = DateTime.Parse("2019-08-01")},
                new Order{IsPaid = true, OrderID=4, UserName="k.tsomisi@gmail.com", Total=100m, OrderDate = DateTime.Parse("2020-01-27")},
                new Order{IsPaid = true, OrderID=5, UserName="a.klopas@gmail.com", Total=25m, OrderDate = DateTime.Parse("2019-07-09")},
                new Order{IsPaid = true, OrderID=6, UserName="p.stergianos@gmail.com", Total=5.4m, OrderDate = DateTime.Parse("2020-03-08")},
                new Order{IsPaid = true, OrderID=7, UserName="k.tsomisi@gmail.com", Total=4.8m, OrderDate = DateTime.Parse("2019-11-03")},
                new Order{IsPaid = true, OrderID=8, UserName="s.polatsidis@gmail.com", Total=31m, OrderDate = DateTime.Parse("2020-08-17")},
                new Order{IsPaid = true, OrderID=9, UserName="a.klopas@gmail.com", Total=2.4m, OrderDate = DateTime.Parse("2019-06-10")},
                new Order{IsPaid = true, OrderID=10, UserName="k.tsomisi@gmail.com", Total=3m, OrderDate = DateTime.Parse("2020-12-01")},
                new Order{IsPaid = true, OrderID=11, UserName="a.klopas@gmail.com", Total=1.4m, OrderDate = DateTime.Parse("2019-02-11")},
                new Order{IsPaid = true, OrderID=12, UserName="p.stergianos@gmail.com", Total=12.5m, OrderDate = DateTime.Parse("2020-05-30")},
                new Order{IsPaid = true, OrderID=13, UserName="k.tsomisi@gmail.com", Total=105m, OrderDate = DateTime.Parse("2019-09-01")},
                new Order{IsPaid = true, OrderID=14, UserName="a.klopas@gmail.com", Total=34.3m, OrderDate = DateTime.Parse("2020-10-18")},
                new Order{IsPaid = true, OrderID=15, UserName="m.syti@gmail.com", Total=2.2m, OrderDate = DateTime.Parse("2019-01-07")},
                new Order{IsPaid = true, OrderID=16, UserName="k.tsomisi@gmail.com", Total=2.7m, OrderDate = DateTime.Parse("2020-12-09")},
                new Order{IsPaid = true, OrderID=17, UserName="p.stergianos@gmail.com", Total=1.85m, OrderDate = DateTime.Parse("2019-04-16")},
                new Order{IsPaid = true, OrderID=18, UserName="a.klopas@gmail.com", Total=1.5m, OrderDate = DateTime.Parse("2020-11-01")},
                new Order{IsPaid = true, OrderID=19, UserName="k.tsomisi@gmail.com", Total=8.4m, OrderDate = DateTime.Parse("2019-01-22")},
                new Order{IsPaid = true, OrderID=20, UserName="s.polatsidis@gmail.com", Total=12m, OrderDate = DateTime.Parse("2020-09-21")},
                new Order{IsPaid = true, OrderID=21, UserName="a.klopas@gmail.com", Total=10m, OrderDate = DateTime.Parse("2019-07-10")},
                new Order{IsPaid = true, OrderID=22, UserName="k.tsomisi@gmail.com", Total=14m, OrderDate = DateTime.Parse("2020-09-14")},
                new Order{IsPaid = true, OrderID=23, UserName="m.syti@gmail.com", Total=250m, OrderDate = DateTime.Parse("2019-06-17")},
                new Order{IsPaid = true, OrderID=24, UserName="a.klopas@gmail.com", Total=10m, OrderDate = DateTime.Parse("2020-01-06")},
                new Order{IsPaid = true, OrderID=25, UserName="k.tsomisi@gmail.com", Total=23.8m, OrderDate = DateTime.Parse("2019-05-11")},
                new Order{IsPaid = true, OrderID=26, UserName="a.klopas@gmail.com", Total=2m, OrderDate = DateTime.Parse("2020-08-05")},
                new Order{IsPaid = true, OrderID=27, UserName="a.klopas@gmail.com", Total=8m, OrderDate = DateTime.Parse("2019-11-07")},
                new Order{IsPaid = true, OrderID=28, UserName="k.tsomisi@gmail.com", Total=16.2m, OrderDate = DateTime.Parse("2020-09-10")},
                new Order{IsPaid = true, OrderID=29, UserName="a.klopas@gmail.com", Total=6m, OrderDate = DateTime.Parse("2019-07-01")},
                new Order{IsPaid = true, OrderID=30, UserName="m.syti@gmail.com", Total=4m, OrderDate = DateTime.Parse("2020-09-22")},
                new Order{IsPaid = true, OrderID=31, UserName="k.tsomisi@gmail.com", Total=12m, OrderDate = DateTime.Parse("2019-12-08")},
                new Order{IsPaid = true, OrderID=32, UserName="a.klopas@gmail.com", Total=16m, OrderDate = DateTime.Parse("2020-10-01")},
                new Order{IsPaid = true, OrderID=33, UserName="a.klopas@gmail.com", Total=28m, OrderDate = DateTime.Parse("2020-12-10")},
                new Order{IsPaid = true, OrderID=34, UserName="k.tsomisi@gmail.com", Total=62.1m, OrderDate = DateTime.Parse("2020-01-27")},
                new Order{IsPaid = true, OrderID=35, UserName="a.klopas@gmail.com", Total=1.8m, OrderDate = DateTime.Parse("2019-07-09")},
                new Order{IsPaid = true, OrderID=36, UserName="k.tsomisi@gmail.com", Total=50m, OrderDate = DateTime.Parse("2020-07-18")},
                new Order{IsPaid = true, OrderID=37, UserName="m.syti@gmail.com", Total=6.3m, OrderDate = DateTime.Parse("2019-11-03")},
                new Order{IsPaid = true, OrderID=38, UserName="a.klopas@gmail.com", Total=9.1m, OrderDate = DateTime.Parse("2020-10-23")},
                new Order{IsPaid = true, OrderID=39, UserName="k.tsomisi@gmail.com", Total=4.2m, OrderDate = DateTime.Parse("2020-09-19")},
                new Order{IsPaid = true, OrderID=40, UserName="a.klopas@gmail.com", Total=24m, OrderDate = DateTime.Parse("2020-12-01")},
                new Order{IsPaid = true, OrderID=41, UserName="a.klopas@gmail.com", Total=8m, OrderDate = DateTime.Parse("2019-12-08")},
                new Order{IsPaid = true, OrderID=42, UserName="k.tsomisi@gmail.com", Total=9.6m, OrderDate = DateTime.Parse("2020-07-21")},
                new Order{IsPaid = true, OrderID=43, UserName="a.klopas@gmail.com", Total=22.4m, OrderDate = DateTime.Parse("2019-08-01")},
                new Order{IsPaid = true, OrderID=44, UserName="s.polatsidis@gmail.com", Total=21m, OrderDate = DateTime.Parse("2020-01-27")},
                new Order{IsPaid = true, OrderID=45, UserName="k.tsomisi@gmail.com", Total=3m, OrderDate = DateTime.Parse("2020-07-28")},
                new Order{IsPaid = true, OrderID=46, UserName="m.syti@gmail.com", Total=7.2m, OrderDate = DateTime.Parse("2020-03-08")},
                new Order{IsPaid = true, OrderID=47, UserName="a.klopas@gmail.com", Total=13.3m, OrderDate = DateTime.Parse("2019-11-03")},
                new Order{IsPaid = true, OrderID=48, UserName="k.tsomisi@gmail.com", Total=5m, OrderDate = DateTime.Parse("2020-08-17")},
                new Order{IsPaid = true, OrderID=49, UserName="m.syti@gmail.com", Total=14.5m, OrderDate = DateTime.Parse("2020-11-14")},
                new Order{IsPaid = true, OrderID=50, UserName="a.klopas@gmail.com", Total=20m, OrderDate = DateTime.Parse("2020-06-02")}
            };
            orders.ForEach(o => context.Orders.AddOrUpdate(o));
            context.SaveChanges();

            List<OrderDetail> orderDetails = new List<OrderDetail>
            {
                //1o Order
                new OrderDetail{OrderDetailID=1, OrderID=1, ProductID=2, Quantity =1, UnitPrice =10m},
                new OrderDetail{OrderDetailID=2, OrderID=1, ProductID=4, Quantity =4, UnitPrice =10m},
                new OrderDetail{OrderDetailID=3, OrderID=1, ProductID=3, Quantity =1, UnitPrice =10m},
                new OrderDetail{OrderDetailID=4, OrderID=1, ProductID=9, Quantity =3, UnitPrice =10m},
                new OrderDetail{OrderDetailID=5, OrderID=1, ProductID=5, Quantity =2, UnitPrice =10m},
                //2o order
                new OrderDetail{OrderDetailID=6, OrderID=2, ProductID=14, Quantity=4, UnitPrice =1m},
                new OrderDetail{OrderDetailID=7, OrderID=2, ProductID=15, Quantity=1, UnitPrice =1m},
                new OrderDetail{OrderDetailID=8, OrderID=2, ProductID=16, Quantity=2, UnitPrice =1m},
                new OrderDetail{OrderDetailID=9, OrderID=2, ProductID=13, Quantity=5, UnitPrice =1m},
                //3o order
                new OrderDetail{OrderDetailID=10, OrderID=3, ProductID=44, Quantity=6, UnitPrice =1m},
                new OrderDetail{OrderDetailID=11, OrderID=3, ProductID=2, Quantity=2, UnitPrice =1m},
                new OrderDetail{OrderDetailID=12, OrderID=3, ProductID=16, Quantity=4, UnitPrice =1m},
                new OrderDetail{OrderDetailID=13, OrderID=3, ProductID=19, Quantity=6, UnitPrice =1m},
                //4o order
                new OrderDetail{OrderDetailID=14, OrderID=4, ProductID=21, Quantity=10, UnitPrice =10m},
                new OrderDetail{OrderDetailID=15, OrderID=4, ProductID=24, Quantity=2, UnitPrice =10m},
                new OrderDetail{OrderDetailID=16, OrderID=4, ProductID=49, Quantity=1, UnitPrice =10m},
                new OrderDetail{OrderDetailID=17, OrderID=4, ProductID=51, Quantity=1, UnitPrice =10m},
                //5o order
                new OrderDetail{OrderDetailID=18, OrderID=5, ProductID=46, Quantity=5, UnitPrice =5m},
                new OrderDetail{OrderDetailID=19, OrderID=5, ProductID=9, Quantity=5, UnitPrice =5m},
                new OrderDetail{OrderDetailID=20, OrderID=5, ProductID=2, Quantity=5, UnitPrice =5m},
                //6o order
                new OrderDetail{OrderDetailID=21, OrderID=6, ProductID=5, Quantity=6, UnitPrice =0.9m},
                new OrderDetail{OrderDetailID=22, OrderID=6, ProductID=21, Quantity=6, UnitPrice =0.9m},
                new OrderDetail{OrderDetailID=23, OrderID=6, ProductID=12, Quantity=5, UnitPrice =0.9m},
                new OrderDetail{OrderDetailID=24, OrderID=6, ProductID=17, Quantity=6, UnitPrice =0.9m},
                //7o order
                new OrderDetail{OrderDetailID=25, OrderID=7, ProductID=21, Quantity=2, UnitPrice =2.4m},
                new OrderDetail{OrderDetailID=26, OrderID=7, ProductID=18, Quantity=2, UnitPrice =2.4m},
                new OrderDetail{OrderDetailID=27, OrderID=7, ProductID=31, Quantity=2, UnitPrice =2.4m},
                //8o order
                new OrderDetail{OrderDetailID=28, OrderID=8, ProductID=27, Quantity=10, UnitPrice =3.1m},
                new OrderDetail{OrderDetailID=29, OrderID=8, ProductID=16, Quantity=4, UnitPrice =3.1m},
                //9o order
                new OrderDetail{OrderDetailID=30, OrderID=9, ProductID=47, Quantity=3, UnitPrice =0.8m},
                new OrderDetail{OrderDetailID=31, OrderID=9, ProductID=35, Quantity=3, UnitPrice =0.8m},
                new OrderDetail{OrderDetailID=32, OrderID=9, ProductID=18, Quantity=3, UnitPrice =0.8m},
                //10o order
                new OrderDetail{OrderDetailID=33, OrderID=10, ProductID=25, Quantity=3, UnitPrice =1m},
                new OrderDetail{OrderDetailID=34, OrderID=10, ProductID=21, Quantity=3, UnitPrice =1m},
                new OrderDetail{OrderDetailID=35, OrderID=10, ProductID=20, Quantity=3, UnitPrice =1m},
                //11o order
                new OrderDetail{OrderDetailID=36, OrderID=11, ProductID=38, Quantity =1, UnitPrice =1.4m},
                new OrderDetail{OrderDetailID=37, OrderID=11, ProductID=22, Quantity =1, UnitPrice =1.4m},
                //12o order
                new OrderDetail{OrderDetailID=38, OrderID=12, ProductID=52, Quantity =5, UnitPrice =2.5m},
                new OrderDetail{OrderDetailID=39, OrderID=12, ProductID=17, Quantity =5, UnitPrice =2.5m},
                new OrderDetail{OrderDetailID=40, OrderID=12, ProductID=24, Quantity =5, UnitPrice =2.5m},
                //13o order
                new OrderDetail{OrderDetailID=41, OrderID=13, ProductID=26, Quantity =7, UnitPrice =15m},
                new OrderDetail{OrderDetailID=42, OrderID=13, ProductID=4, Quantity =7, UnitPrice =15m},
                //14o order
                new OrderDetail{OrderDetailID=43, OrderID=14, ProductID=8, Quantity =7, UnitPrice =4.9m},
                new OrderDetail{OrderDetailID=44, OrderID=14, ProductID=28, Quantity =7, UnitPrice =4.9m},
                //15o order
                new OrderDetail{OrderDetailID=45, OrderID=15, ProductID=9, Quantity =1, UnitPrice =2.2m},
                new OrderDetail{OrderDetailID=46, OrderID=15, ProductID=30, Quantity =1, UnitPrice =2.2m},
                //16o order
                new OrderDetail{OrderDetailID=47, OrderID=16, ProductID=21, Quantity =3, UnitPrice =0.9m},
                new OrderDetail{OrderDetailID=48, OrderID=16, ProductID=32, Quantity =3, UnitPrice =0.9m},
                new OrderDetail{OrderDetailID=49, OrderID=16, ProductID=35, Quantity =3, UnitPrice =0.9m},
                //17o order
                new OrderDetail{OrderDetailID=50, OrderID=17, ProductID=21, Quantity =1, UnitPrice =1.85m},
                new OrderDetail{OrderDetailID=51, OrderID=17, ProductID=34, Quantity =1, UnitPrice =1.85m},
                //18o order
                new OrderDetail{OrderDetailID=52, OrderID=18, ProductID=36, Quantity =1, UnitPrice =1.5m},
                new OrderDetail{OrderDetailID=53, OrderID=18, ProductID=26, Quantity =1, UnitPrice =1.5m},
                //19o order
                new OrderDetail{OrderDetailID=54, OrderID=19, ProductID=34, Quantity =4, UnitPrice =2.1m},
                new OrderDetail{OrderDetailID=55, OrderID=19, ProductID=38, Quantity =4, UnitPrice =2.1m},
                //20o order
                new OrderDetail{OrderDetailID=56, OrderID=20, ProductID=41, Quantity =4, UnitPrice =3m},
                new OrderDetail{OrderDetailID=57, OrderID=20, ProductID=40, Quantity =4, UnitPrice =3m},
                //21o order
                new OrderDetail{OrderDetailID=58, OrderID=21, ProductID=42, Quantity =4, UnitPrice =2.5m},
                new OrderDetail{OrderDetailID=59, OrderID=21, ProductID=24, Quantity =4, UnitPrice =2.5m},
                //22o order
                new OrderDetail{OrderDetailID=60, OrderID=22, ProductID=28, Quantity =7, UnitPrice =2m},
                new OrderDetail{OrderDetailID=61, OrderID=22, ProductID=44, Quantity =7, UnitPrice =2m},
                //23o order
                new OrderDetail{OrderDetailID=62, OrderID=23, ProductID=26, Quantity =10, UnitPrice =25m},
                new OrderDetail{OrderDetailID=63, OrderID=23, ProductID=46, Quantity =10, UnitPrice =25m},
                //24o order
                new OrderDetail{OrderDetailID=64, OrderID=24, ProductID=31, Quantity =5, UnitPrice =2m},
                new OrderDetail{OrderDetailID=65, OrderID=24, ProductID=48, Quantity =5, UnitPrice =2m},
                //25o order
                new OrderDetail{OrderDetailID=66, OrderID=25, ProductID=34, Quantity =2, UnitPrice =11.9m},
                new OrderDetail{OrderDetailID=67, OrderID=25, ProductID=50, Quantity =2, UnitPrice =11.9m},
                //26o order
                new OrderDetail{OrderDetailID=68, OrderID=26, ProductID=44, Quantity =1, UnitPrice =2m},
                new OrderDetail{OrderDetailID=69, OrderID=26, ProductID=52, Quantity =1, UnitPrice =2m},
                //27o order
                new OrderDetail{OrderDetailID=70, OrderID=27, ProductID=54, Quantity =8, UnitPrice =1m},
                new OrderDetail{OrderDetailID=71, OrderID=27, ProductID=41, Quantity =8, UnitPrice =1m},
                //28o order
                new OrderDetail{OrderDetailID=72, OrderID=28, ProductID=56, Quantity =8, UnitPrice =2.7m},
                new OrderDetail{OrderDetailID=73, OrderID=28, ProductID=41, Quantity =2, UnitPrice =2.7m},
                //29o order
                new OrderDetail{OrderDetailID=74, OrderID=29, ProductID=18, Quantity =2, UnitPrice =3m},
                new OrderDetail{OrderDetailID=75, OrderID=29, ProductID=3, Quantity =2, UnitPrice =3m},
                //30o order
                new OrderDetail{OrderDetailID=76, OrderID=30, ProductID=11, Quantity =4, UnitPrice =1m},
                new OrderDetail{OrderDetailID=77, OrderID=30, ProductID=5, Quantity =4, UnitPrice =1m},
                //31o order
                new OrderDetail{OrderDetailID=78, OrderID=31, ProductID=15, Quantity =4, UnitPrice =3m},
                new OrderDetail{OrderDetailID=79, OrderID=31, ProductID=7, Quantity =4, UnitPrice =3m},
                //32o order
                new OrderDetail{OrderDetailID=80, OrderID=32, ProductID=19, Quantity =4, UnitPrice =4m},
                new OrderDetail{OrderDetailID=81, OrderID=32, ProductID=9, Quantity =4, UnitPrice =4m},
                //33o order
                new OrderDetail{OrderDetailID=82, OrderID=33, ProductID=15, Quantity =3, UnitPrice =3.5m},
                new OrderDetail{OrderDetailID=83, OrderID=33, ProductID=11, Quantity =8, UnitPrice =3.5m},
                //34o order
                new OrderDetail{OrderDetailID=83, OrderID=34, ProductID=5, Quantity =5, UnitPrice =6.9m},
                new OrderDetail{OrderDetailID=84, OrderID=34, ProductID=13, Quantity =9, UnitPrice =6.9m},
                //35o order                   
                new OrderDetail{OrderDetailID=85, OrderID=35, ProductID=2, Quantity =3, UnitPrice =0.9m},
                new OrderDetail{OrderDetailID=86, OrderID=35, ProductID=15, Quantity =2, UnitPrice =0.9m},
                //36o order                   
                new OrderDetail{OrderDetailID=87, OrderID=36, ProductID=6, Quantity =6, UnitPrice =10m},
                new OrderDetail{OrderDetailID=88, OrderID=36, ProductID=17, Quantity =5, UnitPrice =10m},
                //37o order                   
                new OrderDetail{OrderDetailID=89, OrderID=37, ProductID=7, Quantity =3, UnitPrice =0.7m},
                new OrderDetail{OrderDetailID=90, OrderID=37, ProductID=19, Quantity =9, UnitPrice =0.7m},
                //38o order
                new OrderDetail{OrderDetailID=91, OrderID=38, ProductID=8, Quantity =7, UnitPrice =1.3m},
                new OrderDetail{OrderDetailID=92, OrderID=38, ProductID=21, Quantity =7, UnitPrice =1.3m},
                //39o order
                new OrderDetail{OrderDetailID=93, OrderID=39, ProductID=6, Quantity =3, UnitPrice =1.4m},
                new OrderDetail{OrderDetailID=94, OrderID=39, ProductID=23, Quantity =3, UnitPrice =1.4m},
                //40o order
                new OrderDetail{OrderDetailID=95, OrderID=40, ProductID=3, Quantity =3, UnitPrice =4m},
                new OrderDetail{OrderDetailID=96, OrderID=40, ProductID=25, Quantity =6, UnitPrice =4m},
                //41o order
                new OrderDetail{OrderDetailID=97, OrderID=41, ProductID=2, Quantity =5, UnitPrice =1m},
                new OrderDetail{OrderDetailID=98, OrderID=41, ProductID=27, Quantity =8, UnitPrice =1m},
                //42o order
                new OrderDetail{OrderDetailID=99, OrderID=42, ProductID=4, Quantity =5, UnitPrice =3.2m},
                new OrderDetail{OrderDetailID=100, OrderID=42, ProductID=29, Quantity =3, UnitPrice =3.2m},
                //43o order
                new OrderDetail{OrderDetailID=101, OrderID=43, ProductID=1, Quantity =8, UnitPrice =2.8m},
                new OrderDetail{OrderDetailID=102, OrderID=43, ProductID=31, Quantity =8, UnitPrice =2.8m},
                //44o order
                new OrderDetail{OrderDetailID=103, OrderID=44, ProductID=6, Quantity =3, UnitPrice =3.5m},
                new OrderDetail{OrderDetailID=104, OrderID=44, ProductID=33, Quantity =6, UnitPrice =3.5m},
                //45o order
                new OrderDetail{OrderDetailID=105, OrderID=45, ProductID=7, Quantity =2, UnitPrice =1.5m},
                new OrderDetail{OrderDetailID=106, OrderID=45, ProductID=35, Quantity =2, UnitPrice =1.5m},
                //46o order
                new OrderDetail{OrderDetailID=107, OrderID=46, ProductID=2, Quantity =3, UnitPrice =2.4m},
                new OrderDetail{OrderDetailID=108, OrderID=46, ProductID=37, Quantity =3, UnitPrice =2.4m},
                //47o order
                new OrderDetail{OrderDetailID=109, OrderID=47, ProductID=1, Quantity =7, UnitPrice =1.9m},
                new OrderDetail{OrderDetailID=110, OrderID=47, ProductID=39, Quantity =7, UnitPrice =1.9m},
                //48o order
                new OrderDetail{OrderDetailID=111, OrderID=48, ProductID=4, Quantity =1, UnitPrice =1m},
                new OrderDetail{OrderDetailID=112, OrderID=48, ProductID=41, Quantity =5, UnitPrice =1m},
                //49o order
                new OrderDetail{OrderDetailID=113, OrderID=49, ProductID=7, Quantity =2, UnitPrice =1.5m},
                new OrderDetail{OrderDetailID=114, OrderID=49, ProductID=43, Quantity =3, UnitPrice =1.5m},
                //50o order
                new OrderDetail{OrderDetailID=115, OrderID=50, ProductID=9, Quantity =8, UnitPrice =2.5m},
                new OrderDetail{OrderDetailID=116, OrderID=50, ProductID=45, Quantity =8, UnitPrice =2.5m}
            };
            orderDetails.ForEach(o => context.OrderDetails.AddOrUpdate(o));
            context.SaveChanges();
        }
    }
}