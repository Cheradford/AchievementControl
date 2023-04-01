using RESTFull.Domain;
using RESTFull.Infrastructure;
using System.Numerics;

namespace TestProject1
{
    public class TestPersonRepository
    {
        [Fact]
        public void VoidTest()
        {
            var testHelper = new TestHelper();
            var personRepository = testHelper.PersonRepository;

            Assert.Equal(1, 1);
        }

        [Fact] 
        public void FillDB()
        {
            var testHelper = new TestHelper();
            var personRepository = testHelper.PersonRepository;
            Context _context = personRepository.UnitOfWork;

            var Persons = new[] {
                new {
                    Personid = 1,
                    name = "Branden",
                    surname = "Barber",
                    patronymic = "Karly",
                    Passport = "14745835-5"
                },
                new {
                    Personid = 2,
                    name = "Georgia",
                    surname = "Warren",
                    patronymic = "Piper",
                    Passport = "40149436-7"
                },
                new {
                    Personid = 3,
                    name = "Fuller",
                    surname = "Sutton",
                    patronymic = "Donna",
                    Passport = "44146409-6"
                },
                new {
                    Personid = 4,
                    name = "Lois",
                    surname = "Ellison",
                    patronymic = "Arthur",
                    Passport = "46291570-5"
                },
                new {
                    Personid = 5,
                    name = "Unity",
                    surname = "Andrews",
                    patronymic = "Shannon",
                    Passport = "9896556-4"
                },
                new {
                    Personid = 6,
                    name = "Eaton",
                    surname = "Lucas",
                    patronymic = "Madonna",
                    Passport = "39305310-0"
                },
                new {
                    Personid = 7,
                    name = "Kevin",
                    surname = "Hughes",
                    patronymic = "Serina",
                    Passport = "37490724-7"
                },
                new {
                    Personid = 8,
                    name = "Imogene",
                    surname = "Wolfe",
                    patronymic = "Jonah",
                    Passport = "1344116-2"
                },
                new {
                    Personid = 9,
                    name = "Inez",
                    surname = "Gillespie",
                    patronymic = "Wyatt",
                    Passport = "36205477-K"
                },
                new {
                    Personid = 10,
                    name = "Keane",
                    surname = "Clark",
                    patronymic = "Miriam",
                    Passport = "13485217-8"
                },
                new {
                    Personid = 11,
                    name = "Oleg",
                    surname = "Jackson",
                    patronymic = "Arsenio",
                    Passport = "22233392-K"
                },
                new {
                    Personid = 12,
                    name = "Sylvester",
                    surname = "Lindsey",
                    patronymic = "Tyler",
                    Passport = "25289608-2"
                },
                new {
                    Personid = 13,
                    name = "Eagan",
                    surname = "Greene",
                    patronymic = "Reese",
                    Passport = "24783680-2"
                },
                new {
                    Personid = 14,
                    name = "Stacy",
                    surname = "Sellers",
                    patronymic = "Freya",
                    Passport = "20172353-1"
                },
                new {
                    Personid = 15,
                    name = "Tanner",
                    surname = "Hicks",
                    patronymic = "Ramona",
                    Passport = "3610443-0"
                },
                new {
                    Personid = 16,
                    name = "Fiona",
                    surname = "Bowen",
                    patronymic = "Andrew",
                    Passport = "24411528-4"
                },
                new {
                    Personid = 17,
                    name = "Scott",
                    surname = "Monroe",
                    patronymic = "Dylan",
                    Passport = "32816979-7"
                },
                new {
                    Personid = 18,
                    name = "Russell",
                    surname = "Hines",
                    patronymic = "Patricia",
                    Passport = "4150817-5"
                },
                new {
                    Personid = 19,
                    name = "Maya",
                    surname = "Shields",
                    patronymic = "Lareina",
                    Passport = "23440890-9"
                },
                new {
                    Personid = 20,
                    name = "Gary",
                    surname = "Cunningham",
                    patronymic = "Yasir",
                    Passport = "9373196-4"
                },
                new {
                    Personid = 21,
                    name = "Steven",
                    surname = "Kirkland",
                    patronymic = "Libby",
                    Passport = "29306593-4"
                },
                new {
                    Personid = 22,
                    name = "Lunea",
                    surname = "Petty",
                    patronymic = "Clark",
                    Passport = "2476260-2"
                },
                new {
                    Personid = 23,
                    name = "Harrison",
                    surname = "Farmer",
                    patronymic = "Raphael",
                    Passport = "9168270-2"
                },
                new {
                    Personid = 24,
                    name = "Kellie",
                    surname = "Sampson",
                    patronymic = "Ivan",
                    Passport = "18801760-6"
                },
                new {
                    Personid = 25,
                    name = "Joan",
                    surname = "Allison",
                    patronymic = "Lev",
                    Passport = "41614682-9"
                },
                new {
                    Personid = 26,
                    name = "Portia",
                    surname = "Williams",
                    patronymic = "Charity",
                    Passport = "38523329-9"
                },
                new {
                    Personid = 27,
                    name = "Dominic",
                    surname = "Alford",
                    patronymic = "Connor",
                    Passport = "31488571-6"
                },
                new {
                    Personid = 28,
                    name = "Ezra",
                    surname = "Richard",
                    patronymic = "Charissa",
                    Passport = "21936373-7"
                },
                new {
                    Personid = 29,
                    name = "Graiden",
                    surname = "Horne",
                    patronymic = "Elijah",
                    Passport = "34842391-6"
                },
                new {
                    Personid = 30,
                    name = "Harrison",
                    surname = "Hensley",
                    patronymic = "Jamal",
                    Passport = "10951512-4"
                },
                new {
                    Personid = 31,
                    name = "Burke",
                    surname = "Delaney",
                    patronymic = "Wyatt",
                    Passport = "32980275-2"
                },
                new {
                    Personid = 32,
                    name = "Catherine",
                    surname = "Chase",
                    patronymic = "Kameko",
                    Passport = "3099186-9"
                },
                new {
                    Personid = 33,
                    name = "Bruce",
                    surname = "Bonner",
                    patronymic = "Faith",
                    Passport = "14110990-1"
                },
                new {
                    Personid = 34,
                    name = "Callie",
                    surname = "Mccarthy",
                    patronymic = "Amaya",
                    Passport = "39324147-0"
                },
                new {
                    Personid = 35,
                    name = "Clio",
                    surname = "Jacobson",
                    patronymic = "Buffy",
                    Passport = "875448-9"
                },
                new {
                    Personid = 36,
                    name = "Isabelle",
                    surname = "Watson",
                    patronymic = "Belle",
                    Passport = "25761916-8"
                },
                new {
                    Personid = 37,
                    name = "Yolanda",
                    surname = "Massey",
                    patronymic = "Charity",
                    Passport = "47167895-3"
                },
                new {
                    Personid = 38,
                    name = "Guinevere",
                    surname = "Hardy",
                    patronymic = "Gavin",
                    Passport = "12451509-2"
                },
                new {
                    Personid = 39,
                    name = "Clare",
                    surname = "Hays",
                    patronymic = "Eaton",
                    Passport = "38241870-0"
                },
                new {
                    Personid = 40,
                    name = "Brendan",
                    surname = "Stephenson",
                    patronymic = "Hilel",
                    Passport = "40887665-6"
                },
                new {
                    Personid = 41,
                    name = "Cain",
                    surname = "Nieves",
                    patronymic = "Dean",
                    Passport = "24551278-3"
                },
                new {
                    Personid = 42,
                    name = "Illana",
                    surname = "Arnold",
                    patronymic = "Kirk",
                    Passport = "26566792-9"
                },
                new {
                    Personid = 43,
                    name = "Melvin",
                    surname = "Compton",
                    patronymic = "Kasimir",
                    Passport = "417209-4"
                },
                new {
                    Personid = 44,
                    name = "Branden",
                    surname = "Fleming",
                    patronymic = "Chaney",
                    Passport = "43957270-1"
                },
                new {
                    Personid = 45,
                    name = "Kevyn",
                    surname = "Vasquez",
                    patronymic = "Cruz",
                    Passport = "37136144-8"
                },
                new {
                    Personid = 46,
                    name = "Alexander",
                    surname = "Little",
                    patronymic = "Stephen",
                    Passport = "2734197-7"
                },
                new {
                    Personid = 47,
                    name = "Alfonso",
                    surname = "Baxter",
                    patronymic = "Jessica",
                    Passport = "1770736-1"
                },
                new {
                    Personid = 48,
                    name = "Donovan",
                    surname = "Vance",
                    patronymic = "Ferdinand",
                    Passport = "24105457-8"
                },
                new {
                    Personid = 49,
                    name = "Ian",
                    surname = "Wiley",
                    patronymic = "Medge",
                    Passport = "11310881-9"
                },
                new {
                    Personid = 50,
                    name = "Kylie",
                    surname = "Hess",
                    patronymic = "Dante",
                    Passport = "43852791-5"
                },
                new {
                    Personid = 51,
                    name = "Unity",
                    surname = "Larson",
                    patronymic = "Ralph",
                    Passport = "4461327-1"
                },
                new {
                    Personid = 52,
                    name = "Lee",
                    surname = "Knox",
                    patronymic = "Keaton",
                    Passport = "30700565-4"
                },
                new {
                    Personid = 53,
                    name = "Benedict",
                    surname = "Waller",
                    patronymic = "Charles",
                    Passport = "19422796-5"
                },
                new {
                    Personid = 54,
                    name = "Illiana",
                    surname = "Wright",
                    patronymic = "Rudyard",
                    Passport = "18205424-0"
                },
                new {
                    Personid = 55,
                    name = "Dawn",
                    surname = "Estes",
                    patronymic = "Uriah",
                    Passport = "32565113-K"
                },
                new {
                    Personid = 56,
                    name = "Callie",
                    surname = "Cotton",
                    patronymic = "Ocean",
                    Passport = "39458995-0"
                },
                new {
                    Personid = 57,
                    name = "Odette",
                    surname = "Armstrong",
                    patronymic = "Asher",
                    Passport = "21968124-0"
                },
                new {
                    Personid = 58,
                    name = "Basia",
                    surname = "Patterson",
                    patronymic = "Fuller",
                    Passport = "22510909-5"
                },
                new {
                    Personid = 59,
                    name = "Hop",
                    surname = "Head",
                    patronymic = "Fiona",
                    Passport = "14314173-K"
                },
                new {
                    Personid = 60,
                    name = "Amos",
                    surname = "Rivas",
                    patronymic = "Keefe",
                    Passport = "33313840-9"
                },
                new {
                    Personid = 61,
                    name = "Cooper",
                    surname = "Mcmillan",
                    patronymic = "Rhiannon",
                    Passport = "41817741-1"
                },
                new {
                    Personid = 62,
                    name = "Kay",
                    surname = "Talley",
                    patronymic = "Madaline",
                    Passport = "28807753-3"
                },
                new {
                    Personid = 63,
                    name = "Miriam",
                    surname = "Silva",
                    patronymic = "Connor",
                    Passport = "41710440-2"
                },
                new {
                    Personid = 64,
                    name = "Ulla",
                    surname = "Bowen",
                    patronymic = "May",
                    Passport = "19454666-1"
                },
                new {
                    Personid = 65,
                    name = "Caesar",
                    surname = "Romero",
                    patronymic = "Cynthia",
                    Passport = "37948267-8"
                },
                new {
                    Personid = 66,
                    name = "Abra",
                    surname = "Christensen",
                    patronymic = "Nyssa",
                    Passport = "7237450-9"
                },
                new {
                    Personid = 67,
                    name = "Libby",
                    surname = "Emerson",
                    patronymic = "Winter",
                    Passport = "32807391-9"
                },
                new {
                    Personid = 68,
                    name = "Thomas",
                    surname = "Forbes",
                    patronymic = "Gareth",
                    Passport = "778765-0"
                },
                new {
                    Personid = 69,
                    name = "Whitney",
                    surname = "Ballard",
                    patronymic = "Joshua",
                    Passport = "26188978-1"
                },
                new {
                    Personid = 70,
                    name = "Deanna",
                    surname = "Franklin",
                    patronymic = "Zeph",
                    Passport = "10435513-7"
                },
                new {
                    Personid = 71,
                    name = "Hamilton",
                    surname = "Hoover",
                    patronymic = "Fulton",
                    Passport = "3072889-0"
                },
                new {
                    Personid = 72,
                    name = "Harrison",
                    surname = "Barker",
                    patronymic = "Rebekah",
                    Passport = "49747245-8"
                },
                new {
                    Personid = 73,
                    name = "Camden",
                    surname = "Kennedy",
                    patronymic = "Deacon",
                    Passport = "29610911-8"
                },
                new {
                    Personid = 74,
                    name = "Carlos",
                    surname = "Goodman",
                    patronymic = "Eagan",
                    Passport = "8528743-5"
                },
                new {
                    Personid = 75,
                    name = "Chelsea",
                    surname = "Fisher",
                    patronymic = "Ariana",
                    Passport = "26413290-8"
                },
                new {
                    Personid = 76,
                    name = "Guy",
                    surname = "Drake",
                    patronymic = "Abra",
                    Passport = "134839-6"
                },
                new {
                    Personid = 77,
                    name = "Leonard",
                    surname = "Prince",
                    patronymic = "Illana",
                    Passport = "37780458-9"
                },
                new {
                    Personid = 78,
                    name = "Maite",
                    surname = "Hughes",
                    patronymic = "Rose",
                    Passport = "22179154-1"
                },
                new {
                    Personid = 79,
                    name = "Miriam",
                    surname = "Casey",
                    patronymic = "Gisela",
                    Passport = "20798964-9"
                },
                new {
                    Personid = 80,
                    name = "Ulric",
                    surname = "Roy",
                    patronymic = "Mufutau",
                    Passport = "16130467-0"
                },
                new {
                    Personid = 81,
                    name = "Roanna",
                    surname = "Lynn",
                    patronymic = "Xantha",
                    Passport = "44207790-8"
                },
                new {
                    Personid = 82,
                    name = "Kim",
                    surname = "Fowler",
                    patronymic = "Rhona",
                    Passport = "2832297-6"
                },
                new {
                    Personid = 83,
                    name = "Kimberley",
                    surname = "Waters",
                    patronymic = "Lee",
                    Passport = "41705831-1"
                },
                new {
                    Personid = 84,
                    name = "Aidan",
                    surname = "Waller",
                    patronymic = "Kirby",
                    Passport = "7450917-7"
                },
                new {
                    Personid = 85,
                    name = "Karen",
                    surname = "Britt",
                    patronymic = "Kevyn",
                    Passport = "5534196-6"
                },
                new {
                    Personid = 86,
                    name = "Ulric",
                    surname = "Pruitt",
                    patronymic = "Omar",
                    Passport = "50583966-8"
                },
                new {
                    Personid = 87,
                    name = "Barclay",
                    surname = "Stuart",
                    patronymic = "Buckminster",
                    Passport = "49749211-4"
                },
                new {
                    Personid = 88,
                    name = "Hannah",
                    surname = "Cox",
                    patronymic = "Maisie",
                    Passport = "7884485-K"
                },
                new {
                    Personid = 89,
                    name = "Price",
                    surname = "Craft",
                    patronymic = "Sage",
                    Passport = "32419742-7"
                },
                new {
                    Personid = 90,
                    name = "Daquan",
                    surname = "Dawson",
                    patronymic = "Tobias",
                    Passport = "24366192-7"
                },
                new {
                    Personid = 91,
                    name = "Latifah",
                    surname = "Whitehead",
                    patronymic = "Yoshi",
                    Passport = "21829402-2"
                },
                new {
                    Personid = 92,
                    name = "Mercedes",
                    surname = "Wynn",
                    patronymic = "Tarik",
                    Passport = "3787152-4"
                },
                new {
                    Personid = 93,
                    name = "Vincent",
                    surname = "Henson",
                    patronymic = "Jenette",
                    Passport = "6597237-9"
                },
                new {
                    Personid = 94,
                    name = "George",
                    surname = "Griffin",
                    patronymic = "Cairo",
                    Passport = "23285702-1"
                },
                new {
                    Personid = 95,
                    name = "Donovan",
                    surname = "Kirby",
                    patronymic = "Bert",
                    Passport = "39963516-0"
                },
                new {
                    Personid = 96,
                    name = "Brendan",
                    surname = "Gamble",
                    patronymic = "Cyrus",
                    Passport = "2345424-6"
                },
                new {
                    Personid = 97,
                    name = "Bert",
                    surname = "Mcgee",
                    patronymic = "Faith",
                    Passport = "3899347-K"
                },
                new {
                    Personid = 98,
                    name = "Hop",
                    surname = "Hurley",
                    patronymic = "Paul",
                    Passport = "112859-0"
                },
                new {
                    Personid = 99,
                    name = "Ahmed",
                    surname = "Jenkins",
                    patronymic = "Steven",
                    Passport = "494522-0"
                },
                new {
                    Personid = 100,
                    name = "Hedley",
                    surname = "Kirk",
                    patronymic = "Constance",
                    Passport = "1391847-3"
                }
            };
            var Olimp = new[] {
    new {
        id = 1,
        Achievements = "sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus",
        Link = "http://naver.com/en-ca",
        Form = "dictum",
        Theme = "placerat"
    },
    new {
        id = 2,
        Achievements = "sit amet nulla. Donec non justo. Proin non massa non",
        Link = "https://instagram.com/sub/cars",
        Form = "Cras interdum.",
        Theme = "tempor"
    },
    new {
        id = 3,
        Achievements = "nibh enim, gravida sit amet, dapibus id, blandit at, nisi.",
        Link = "https://baidu.com/en-us",
        Form = "consectetuer euismod",
        Theme = "ipsum"
    },
    new {
        id = 4,
        Achievements = "vel, faucibus id, libero. Donec consectetuer mauris id sapien. Cras",
        Link = "http://facebook.com/site",
        Form = "non, bibendum",
        Theme = "Cum"
    },
    new {
        id = 5,
        Achievements = "tellus. Aenean egestas hendrerit neque. In ornare sagittis felis. Donec",
        Link = "https://netflix.com/sub/cars",
        Form = "lacinia",
        Theme = "sem"
    },
    new {
        id = 6,
        Achievements = "molestie. Sed id risus quis diam luctus lobortis. Class aptent",
        Link = "https://reddit.com/one",
        Form = "Sed et",
        Theme = "dictum"
    },
    new {
        id = 7,
        Achievements = "eget, dictum placerat, augue. Sed molestie. Sed id risus quis",
        Link = "http://yahoo.com/en-ca",
        Form = "semper,",
        Theme = "eu"
    },
    new {
        id = 8,
        Achievements = "sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus",
        Link = "https://zoom.us/en-us",
        Form = "et",
        Theme = "nec"
    },
    new {
        id = 9,
        Achievements = "id ante dictum cursus. Nunc mauris elit, dictum eu, eleifend",
        Link = "https://ebay.com/settings",
        Form = "Cum sociis",
        Theme = "urna"
    },
    new {
        id = 10,
        Achievements = "ullamcorper, nisl arcu iaculis enim, sit amet ornare lectus justo",
        Link = "https://nytimes.com/one",
        Form = "nec",
        Theme = "nunc"
    },
    new {
        id = 11,
        Achievements = "pretium neque. Morbi quis urna. Nunc quis arcu vel quam",
        Link = "https://instagram.com/one",
        Form = "euismod",
        Theme = "Morbi"
    },
    new {
        id = 12,
        Achievements = "fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor,",
        Link = "http://netflix.com/en-ca",
        Form = "est. Nunc",
        Theme = "Mauris"
    },
    new {
        id = 13,
        Achievements = "pellentesque, tellus sem mollis dui, in sodales elit erat vitae",
        Link = "http://ebay.com/settings",
        Form = "egestas",
        Theme = "dapibus"
    },
    new {
        id = 14,
        Achievements = "massa lobortis ultrices. Vivamus rhoncus. Donec est. Nunc ullamcorper, velit",
        Link = "http://guardian.co.uk/site",
        Form = "est mauris,",
        Theme = "Pellentesque"
    },
    new {
        id = 15,
        Achievements = "eu, accumsan sed, facilisis vitae, orci. Phasellus dapibus quam quis",
        Link = "https://nytimes.com/fr",
        Form = "risus.",
        Theme = "cursus"
    },
    new {
        id = 16,
        Achievements = "vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim.",
        Link = "http://walmart.com/site",
        Form = "Integer eu",
        Theme = "tristique"
    },
    new {
        id = 17,
        Achievements = "velit in aliquet lobortis, nisi nibh lacinia orci, consectetuer euismod",
        Link = "http://netflix.com/sub/cars",
        Form = "eget,",
        Theme = "Nunc"
    },
    new {
        id = 18,
        Achievements = "at, velit. Cras lorem lorem, luctus ut, pellentesque eget, dictum",
        Link = "https://guardian.co.uk/group/9",
        Form = "morbi tristique",
        Theme = "est"
    },
    new {
        id = 19,
        Achievements = "magna. Suspendisse tristique neque venenatis lacus. Etiam bibendum fermentum metus.",
        Link = "http://bbc.co.uk/site",
        Form = "adipiscing",
        Theme = "non"
    },
    new {
        id = 20,
        Achievements = "Proin eget odio. Aliquam vulputate ullamcorper magna. Sed eu eros.",
        Link = "https://naver.com/one",
        Form = "felis. Donec",
        Theme = "eget,"
    }
};
            var Sport = new[] {
    new {
        id = 1,
        Achievements = "magna. Praesent interdum ligula eu enim. Etiam imperdiet dictum magna.",
        Link = "https://nytimes.com/user/110",
        Category = "Ut tincidunt",
        Type = "Ut"
    },
    new {
        id = 2,
        Achievements = "consectetuer ipsum nunc id enim. Curabitur massa. Vestibulum accumsan neque",
        Link = "https://youtube.com/sub",
        Category = "quam,",
        Type = "In"
    },
    new {
        id = 3,
        Achievements = "sit amet, faucibus ut, nulla. Cras eu tellus eu augue",
        Link = "http://naver.com/group/9",
        Category = "vel,",
        Type = "Vivamus"
    },
    new {
        id = 4,
        Achievements = "Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu.",
        Link = "https://twitter.com/sub",
        Category = "Duis elementum,",
        Type = "justo"
    },
    new {
        id = 5,
        Achievements = "Donec dignissim magna a tortor. Nunc commodo auctor velit. Aliquam",
        Link = "http://wikipedia.org/en-ca",
        Category = "mollis vitae,",
        Type = "malesuada"
    },
    new {
        id = 6,
        Achievements = "pharetra nibh. Aliquam ornare, libero at auctor ullamcorper, nisl arcu",
        Link = "https://wikipedia.org/en-us",
        Category = "Phasellus",
        Type = "pede."
    },
    new {
        id = 7,
        Achievements = "luctus vulputate, nisi sem semper erat, in consectetuer ipsum nunc",
        Link = "https://whatsapp.com/site",
        Category = "ligula. Aenean",
        Type = "magna"
    },
    new {
        id = 8,
        Achievements = "erat vel pede blandit congue. In scelerisque scelerisque dui. Suspendisse",
        Link = "https://wikipedia.org/user/110",
        Category = "urna",
        Type = "ac"
    },
    new {
        id = 9,
        Achievements = "porttitor scelerisque neque. Nullam nisl. Maecenas malesuada fringilla est. Mauris",
        Link = "https://baidu.com/site",
        Category = "Suspendisse",
        Type = "penatibus"
    },
    new {
        id = 10,
        Achievements = "pretium neque. Morbi quis urna. Nunc quis arcu vel quam",
        Link = "http://whatsapp.com/settings",
        Category = "at pede.",
        Type = "Maecenas"
    },
    new {
        id = 11,
        Achievements = "mollis. Phasellus libero mauris, aliquam eu, accumsan sed, facilisis vitae,",
        Link = "https://nytimes.com/one",
        Category = "tortor at",
        Type = "In"
    },
    new {
        id = 12,
        Achievements = "Aliquam adipiscing lobortis risus. In mi pede, nonummy ut, molestie",
        Link = "http://google.com/one",
        Category = "consectetuer ipsum",
        Type = "Nam"
    },
    new {
        id = 13,
        Achievements = "In faucibus. Morbi vehicula. Pellentesque tincidunt tempus risus. Donec egestas.",
        Link = "https://naver.com/site",
        Category = "faucibus lectus,",
        Type = "magnis"
    },
    new {
        id = 14,
        Achievements = "dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec,",
        Link = "https://zoom.us/site",
        Category = "mus. Proin",
        Type = "Cras"
    },
    new {
        id = 15,
        Achievements = "massa. Mauris vestibulum, neque sed dictum eleifend, nunc risus varius",
        Link = "http://youtube.com/sub/cars",
        Category = "egestas.",
        Type = "pede."
    },
    new {
        id = 16,
        Achievements = "fermentum fermentum arcu. Vestibulum ante ipsum primis in faucibus orci",
        Link = "https://facebook.com/en-us",
        Category = "eu, odio.",
        Type = "non"
    },
    new {
        id = 17,
        Achievements = "quam vel sapien imperdiet ornare. In faucibus. Morbi vehicula. Pellentesque",
        Link = "https://nytimes.com/fr",
        Category = "mollis",
        Type = "at"
    },
    new {
        id = 18,
        Achievements = "semper pretium neque. Morbi quis urna. Nunc quis arcu vel",
        Link = "http://reddit.com/site",
        Category = "bibendum. Donec",
        Type = "magna."
    },
    new {
        id = 19,
        Achievements = "lobortis mauris. Suspendisse aliquet molestie tellus. Aenean egestas hendrerit neque.",
        Link = "https://youtube.com/sub",
        Category = "nisi.",
        Type = "dolor"
    },
    new {
        id = 20,
        Achievements = "habitant morbi tristique senectus et netus et malesuada fames ac",
        Link = "https://zoom.us/group/9",
        Category = "tincidunt adipiscing.",
        Type = "a"
    }
};
            var CrAct = new[] {
    new {
        id = 1,
        Achievements = "lectus. Nullam suscipit, est ac facilisis facilisis, magna tellus faucibus",
        Link = "http://youtube.com/site",
        Type = "Mauris"
    },
    new {
        id = 2,
        Achievements = "nec, malesuada ut, sem. Nulla interdum. Curabitur dictum. Phasellus in",
        Link = "https://pinterest.com/fr",
        Type = "sapien,"
    },
    new {
        id = 3,
        Achievements = "nec luctus felis purus ac tellus. Suspendisse sed dolor. Fusce",
        Link = "http://pinterest.com/en-ca",
        Type = "risus."
    },
    new {
        id = 4,
        Achievements = "Nulla eget metus eu erat semper rutrum. Fusce dolor quam,",
        Link = "https://naver.com/group/9",
        Type = "mi"
    },
    new {
        id = 5,
        Achievements = "sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum",
        Link = "https://zoom.us/user/110",
        Type = "purus"
    },
    new {
        id = 6,
        Achievements = "Praesent eu nulla at sem molestie sodales. Mauris blandit enim",
        Link = "http://naver.com/sub/cars",
        Type = "risus."
    },
    new {
        id = 7,
        Achievements = "Donec luctus aliquet odio. Etiam ligula tortor, dictum eu, placerat",
        Link = "https://baidu.com/en-us",
        Type = "tellus"
    },
    new {
        id = 8,
        Achievements = "lacinia at, iaculis quis, pede. Praesent eu dui. Cum sociis",
        Link = "http://youtube.com/settings",
        Type = "arcu."
    },
    new {
        id = 9,
        Achievements = "enim commodo hendrerit. Donec porttitor tellus non magna. Nam ligula",
        Link = "http://facebook.com/en-us",
        Type = "sed,"
    },
    new {
        id = 10,
        Achievements = "sit amet lorem semper auctor. Mauris vel turpis. Aliquam adipiscing",
        Link = "https://netflix.com/fr",
        Type = "lacinia"
    },
    new {
        id = 11,
        Achievements = "sed pede nec ante blandit viverra. Donec tempus, lorem fringilla",
        Link = "https://reddit.com/site",
        Type = "cursus"
    },
    new {
        id = 12,
        Achievements = "nisl. Maecenas malesuada fringilla est. Mauris eu turpis. Nulla aliquet.",
        Link = "http://reddit.com/site",
        Type = "justo"
    },
    new {
        id = 13,
        Achievements = "Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc",
        Link = "https://zoom.us/site",
        Type = "nec"
    },
    new {
        id = 14,
        Achievements = "penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec",
        Link = "https://nytimes.com/fr",
        Type = "dictum"
    },
    new {
        id = 15,
        Achievements = "dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec,",
        Link = "http://twitter.com/fr",
        Type = "vitae"
    },
    new {
        id = 16,
        Achievements = "eu, ligula. Aenean euismod mauris eu elit. Nulla facilisi. Sed",
        Link = "https://instagram.com/en-us",
        Type = "non"
    },
    new {
        id = 17,
        Achievements = "nunc sed pede. Cum sociis natoque penatibus et magnis dis",
        Link = "https://pinterest.com/user/110",
        Type = "Donec"
    },
    new {
        id = 18,
        Achievements = "dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc",
        Link = "http://reddit.com/en-us",
        Type = "at"
    },
    new {
        id = 19,
        Achievements = "cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin",
        Link = "http://facebook.com/settings",
        Type = "Mauris"
    },
    new {
        id = 20,
        Achievements = "Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc",
        Link = "https://google.com/en-ca",
        Type = "Cras"
    }
};
            var ScAct = new[] {
    new {
        id = 1,
        Achievements = "vehicula risus. Nulla eget metus eu erat semper rutrum. Fusce",
        Link = "https://instagram.com/fr",
        Type = "lobortis"
    },
    new {
        id = 2,
        Achievements = "faucibus lectus, a sollicitudin orci sem eget massa. Suspendisse eleifend.",
        Link = "https://ebay.com/settings",
        Type = "rhoncus"
    },
    new {
        id = 3,
        Achievements = "urna. Ut tincidunt vehicula risus. Nulla eget metus eu erat",
        Link = "https://twitter.com/settings",
        Type = "gravida"
    },
    new {
        id = 4,
        Achievements = "dis parturient montes, nascetur ridiculus mus. Aenean eget magna. Suspendisse",
        Link = "http://nytimes.com/en-us",
        Type = "mollis"
    },
    new {
        id = 5,
        Achievements = "auctor, nunc nulla vulputate dui, nec tempus mauris erat eget",
        Link = "https://guardian.co.uk/sub",
        Type = "leo,"
    },
    new {
        id = 6,
        Achievements = "vitae diam. Proin dolor. Nulla semper tellus id nunc interdum",
        Link = "http://wikipedia.org/site",
        Type = "consectetuer,"
    },
    new {
        id = 7,
        Achievements = "libero. Proin sed turpis nec mauris blandit mattis. Cras eget",
        Link = "https://twitter.com/sub/cars",
        Type = "Cras"
    },
    new {
        id = 8,
        Achievements = "et, magna. Praesent interdum ligula eu enim. Etiam imperdiet dictum",
        Link = "http://baidu.com/en-us",
        Type = "felis"
    },
    new {
        id = 9,
        Achievements = "a ultricies adipiscing, enim mi tempor lorem, eget mollis lectus",
        Link = "http://zoom.us/site",
        Type = "porttitor"
    },
    new {
        id = 10,
        Achievements = "ornare, libero at auctor ullamcorper, nisl arcu iaculis enim, sit",
        Link = "https://pinterest.com/en-us",
        Type = "amet"
    },
    new {
        id = 11,
        Achievements = "arcu eu odio tristique pharetra. Quisque ac libero nec ligula",
        Link = "http://wikipedia.org/en-ca",
        Type = "pede."
    },
    new {
        id = 12,
        Achievements = "eget massa. Suspendisse eleifend. Cras sed leo. Cras vehicula aliquet",
        Link = "http://pinterest.com/group/9",
        Type = "sapien"
    },
    new {
        id = 13,
        Achievements = "ipsum primis in faucibus orci luctus et ultrices posuere cubilia",
        Link = "https://bbc.co.uk/settings",
        Type = "vel"
    },
    new {
        id = 14,
        Achievements = "Fusce aliquet magna a neque. Nullam ut nisi a odio",
        Link = "http://walmart.com/en-us",
        Type = "adipiscing"
    },
    new {
        id = 15,
        Achievements = "Nullam nisl. Maecenas malesuada fringilla est. Mauris eu turpis. Nulla",
        Link = "http://walmart.com/en-ca",
        Type = "urna."
    },
    new {
        id = 16,
        Achievements = "lacus pede sagittis augue, eu tempor erat neque non quam.",
        Link = "http://cnn.com/en-ca",
        Type = "Donec"
    },
    new {
        id = 17,
        Achievements = "risus, at fringilla purus mauris a nunc. In at pede.",
        Link = "https://twitter.com/fr",
        Type = "orci"
    },
    new {
        id = 18,
        Achievements = "pellentesque, tellus sem mollis dui, in sodales elit erat vitae",
        Link = "https://cnn.com/fr",
        Type = "risus"
    },
    new {
        id = 19,
        Achievements = "quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed",
        Link = "http://baidu.com/fr",
        Type = "Integer"
    },
    new {
        id = 20,
        Achievements = "ornare, lectus ante dictum mi, ac mattis velit justo nec",
        Link = "https://baidu.com/en-ca",
        Type = "pharetra"
    }
};
            var IntCont = new[] {
    new {
        id = 1,
        Achievements = "et, rutrum non, hendrerit id, ante. Nunc mauris sapien, cursus",
        Link = "https://walmart.com/group/9",
        Title = "libero lacus, varius",
        Form = "mattis ornare,"
    },
    new {
        id = 2,
        Achievements = "nec, mollis vitae, posuere at, velit. Cras lorem lorem, luctus",
        Link = "https://bbc.co.uk/group/9",
        Title = "aliquam adipiscing",
        Form = "libero. Proin"
    },
    new {
        id = 3,
        Achievements = "enim, gravida sit amet, dapibus id, blandit at, nisi. Cum",
        Link = "https://ebay.com/group/9",
        Title = "Proin mi. Aliquam",
        Form = "magnis dis"
    },
    new {
        id = 4,
        Achievements = "Phasellus dolor elit, pellentesque a, facilisis non, bibendum sed, est.",
        Link = "http://nytimes.com/settings",
        Title = "porttitor tellus",
        Form = "mauris sit"
    },
    new {
        id = 5,
        Achievements = "quis diam. Pellentesque habitant morbi tristique senectus et netus et",
        Link = "https://instagram.com/user/110",
        Title = "sem semper",
        Form = "dolor, nonummy"
    },
    new {
        id = 6,
        Achievements = "vestibulum lorem, sit amet ultricies sem magna nec quam. Curabitur",
        Link = "http://bbc.co.uk/en-ca",
        Title = "vel lectus.",
        Form = "cursus non,"
    },
    new {
        id = 7,
        Achievements = "facilisis vitae, orci. Phasellus dapibus quam quis diam. Pellentesque habitant",
        Link = "https://wikipedia.org/sub/cars",
        Title = "Ut nec",
        Form = "dolor. Quisque"
    },
    new {
        id = 8,
        Achievements = "felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit",
        Link = "https://ebay.com/user/110",
        Title = "penatibus",
        Form = "Curabitur sed"
    },
    new {
        id = 9,
        Achievements = "vel, mauris. Integer sem elit, pharetra ut, pharetra sed, hendrerit",
        Link = "http://nytimes.com/sub/cars",
        Title = "nisi. Mauris nulla.",
        Form = "Aliquam tincidunt,"
    },
    new {
        id = 10,
        Achievements = "dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec,",
        Link = "http://ebay.com/sub/cars",
        Title = "vitae velit egestas",
        Form = "torquent per"
    },
    new {
        id = 11,
        Achievements = "nisl. Nulla eu neque pellentesque massa lobortis ultrices. Vivamus rhoncus.",
        Link = "http://twitter.com/group/9",
        Title = "Duis dignissim",
        Form = "porttitor tellus"
    },
    new {
        id = 12,
        Achievements = "Class aptent taciti sociosqu ad litora torquent per conubia nostra,",
        Link = "http://cnn.com/site",
        Title = "interdum feugiat.",
        Form = "Duis elementum,"
    },
    new {
        id = 13,
        Achievements = "elementum sem, vitae aliquam eros turpis non enim. Mauris quis",
        Link = "https://walmart.com/group/9",
        Title = "tortor nibh",
        Form = "Cras lorem"
    },
    new {
        id = 14,
        Achievements = "lorem semper auctor. Mauris vel turpis. Aliquam adipiscing lobortis risus.",
        Link = "http://yahoo.com/group/9",
        Title = "vestibulum nec,",
        Form = "urna. Nunc"
    },
    new {
        id = 15,
        Achievements = "Nullam scelerisque neque sed sem egestas blandit. Nam nulla magna,",
        Link = "http://youtube.com/fr",
        Title = "Sed neque.",
        Form = "nulla. In"
    },
    new {
        id = 16,
        Achievements = "Quisque porttitor eros nec tellus. Nunc lectus pede, ultrices a,",
        Link = "http://google.com/settings",
        Title = "lectus quis",
        Form = "eu tempor"
    },
    new {
        id = 17,
        Achievements = "Fusce aliquet magna a neque. Nullam ut nisi a odio",
        Link = "http://guardian.co.uk/fr",
        Title = "Etiam",
        Form = "dolor dapibus"
    },
    new {
        id = 18,
        Achievements = "a mi fringilla mi lacinia mattis. Integer eu lacus. Quisque",
        Link = "https://google.com/one",
        Title = "semper tellus id",
        Form = "In faucibus."
    },
    new {
        id = 19,
        Achievements = "sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices",
        Link = "https://zoom.us/fr",
        Title = "non, egestas",
        Form = "sed pede"
    },
    new {
        id = 20,
        Achievements = "Suspendisse ac metus vitae velit egestas lacinia. Sed congue, elit",
        Link = "http://youtube.com/en-us",
        Title = "lacus. Aliquam",
        Form = "amet, faucibus"
    }
};
            var SocCult = new[] {
    new {
        id = 1,
        Achievements = "semper erat, in consectetuer ipsum nunc id enim. Curabitur massa.",
        Link = "http://ebay.com/sub",
        Type = "non magna."
    },
    new {
        id = 2,
        Achievements = "dictum. Proin eget odio. Aliquam vulputate ullamcorper magna. Sed eu",
        Link = "http://twitter.com/sub/cars",
        Type = "non, cursus non,"
    },
    new {
        id = 3,
        Achievements = "aliquam, enim nec tempus scelerisque, lorem ipsum sodales purus, in",
        Link = "http://netflix.com/sub/cars",
        Type = "sem ut"
    },
    new {
        id = 4,
        Achievements = "quam. Pellentesque habitant morbi tristique senectus et netus et malesuada",
        Link = "http://yahoo.com/user/110",
        Type = "feugiat nec, diam."
    },
    new {
        id = 5,
        Achievements = "odio a purus. Duis elementum, dui quis accumsan convallis, ante",
        Link = "https://whatsapp.com/one",
        Type = "aliquet,"
    },
    new {
        id = 6,
        Achievements = "ut quam vel sapien imperdiet ornare. In faucibus. Morbi vehicula.",
        Link = "https://cnn.com/group/9",
        Type = "amet, risus."
    },
    new {
        id = 7,
        Achievements = "Nunc laoreet lectus quis massa. Mauris vestibulum, neque sed dictum",
        Link = "http://whatsapp.com/group/9",
        Type = "at, nisi."
    },
    new {
        id = 8,
        Achievements = "Integer id magna et ipsum cursus vestibulum. Mauris magna. Duis",
        Link = "https://nytimes.com/user/110",
        Type = "odio."
    },
    new {
        id = 9,
        Achievements = "cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula",
        Link = "https://pinterest.com/sub",
        Type = "dapibus gravida. Aliquam"
    },
    new {
        id = 10,
        Achievements = "amet diam eu dolor egestas rhoncus. Proin nisl sem, consequat",
        Link = "https://ebay.com/fr",
        Type = "congue,"
    },
    new {
        id = 11,
        Achievements = "magna nec quam. Curabitur vel lectus. Cum sociis natoque penatibus",
        Link = "https://guardian.co.uk/en-ca",
        Type = "augue id"
    },
    new {
        id = 12,
        Achievements = "elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et",
        Link = "https://facebook.com/one",
        Type = "mauris sit amet"
    },
    new {
        id = 13,
        Achievements = "neque sed dictum eleifend, nunc risus varius orci, in consequat",
        Link = "https://bbc.co.uk/settings",
        Type = "rhoncus."
    },
    new {
        id = 14,
        Achievements = "eu erat semper rutrum. Fusce dolor quam, elementum at, egestas",
        Link = "http://instagram.com/sub",
        Type = "odio semper cursus."
    },
    new {
        id = 15,
        Achievements = "urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus",
        Link = "https://wikipedia.org/site",
        Type = "libero"
    },
    new {
        id = 16,
        Achievements = "arcu. Vestibulum ut eros non enim commodo hendrerit. Donec porttitor",
        Link = "http://netflix.com/settings",
        Type = "elit elit"
    },
    new {
        id = 17,
        Achievements = "In lorem. Donec elementum, lorem ut aliquam iaculis, lacus pede",
        Link = "http://wikipedia.org/en-ca",
        Type = "Donec elementum,"
    },
    new {
        id = 18,
        Achievements = "est. Nunc ullamcorper, velit in aliquet lobortis, nisi nibh lacinia",
        Link = "http://youtube.com/site",
        Type = "amet, faucibus"
    },
    new {
        id = 19,
        Achievements = "blandit enim consequat purus. Maecenas libero est, congue a, aliquet",
        Link = "http://reddit.com/sub/cars",
        Type = "mi"
    },
    new {
        id = 20,
        Achievements = "odio. Nam interdum enim non nisi. Aenean eget metus. In",
        Link = "https://reddit.com/settings",
        Type = "purus ac tellus."
    }
};

            for (int i = 0; i < Persons.Length; i++)
            {
                var person = Persons[i];
                Person temp = new Person { Personid = person.Personid, name = person.name, surname = person.surname, patronymic = person.patronymic, Passport = person.Passport };
                if (i < 20)
                {
                    var olimp = Olimp[i];
                    var socCult = SocCult[i];
                    temp.Achievement.Add(new Olympiads { id = i + 100, Achievements = olimp.Achievements, Date = DateTime.Now, Link = olimp.Link, Theme = olimp.Theme, Form = olimp.Form });
                    temp.Achievement.Add(new SocioCultural { id = i+200, Achievements = socCult.Achievements, Date = DateTime.Now, Link = socCult.Link, Type = socCult.Type });
                }
                else if (i < 40)
                {
                    var sport = Sport[i % 20];
                    temp.Achievement.Add(new Sport { id = i+300, Achievements = sport.Achievements, Date = DateTime.Now, Link = sport.Link, Category = sport.Category, Type = sport.Type });
                }
                else if (i < 60)
                {
                    var crAct = CrAct[i % 20];
                    temp.Achievement.Add(new CreativeActivities { id = i+400, Achievements = crAct.Achievements, Date = DateTime.Now, Link = crAct.Link, Type = crAct.Type });
                }
                else if (i < 80)
                {
                    var scAct = ScAct[i % 20];
                    temp.Achievement.Add(new ScienceActivities { id = i+500, Achievements = scAct.Achievements, Date = DateTime.Now, Link = scAct.Link, Type = scAct.Type });
                }
                else if (i < 100)
                {
                    var intCont = IntCont[i % 20];
                    temp.Achievement.Add(new IntellectualContests { id = i+600, Achievements = intCont.Achievements, Date = DateTime.Now, Link = intCont.Link, Form = intCont.Form, Title = intCont.Title });
                }
                _context.Persons.Add(temp);
            }
            _context.SaveChanges();
            Assert.Equal(1, 1);
        }
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var personRepository = testHelper.PersonRepository;
            var person = new Person { Personid = 2012 ,name = "Peter", surname = "Parker" };

            personRepository.AddAsync(person).Wait();
            personRepository.ChangeTrackerClear();

            Assert.True(personRepository.GetAllAsync().Result.Count == 3);
            Assert.Equal("Potter", personRepository.GetBySurnameAsync("Potter").Result.surname);
            Assert.Equal("Hopper", personRepository.GetBySurnameAsync("Hopper").Result.surname);
            Assert.Equal("Parker", personRepository.GetBySurnameAsync("Parker").Result.surname);
            Assert.Equal(1, personRepository.GetBySurnameAsync("Potter").Result.Achievement.Count);
        }

        [Fact]
        public void TestUpdateAdd()
        {
            var testHelper = new TestHelper();
            var personRepository = testHelper.PersonRepository;
            var person = personRepository.GetBySurnameAsync("Potter").Result;
            personRepository.ChangeTrackerClear();
            person.name = "Peter";
            person.surname = "Parker";
            var Achievement = new Achievement { id = 19, Achievements = "Saving The World", Date = DateTime.ParseExact("13.06.2022", "dd.MM.yyyy", null), Link = "https://www.youtube.com/watch?v=-tnxzJ0SSOw" };
            person.Achievement.Add(Achievement);

            personRepository.UpdateAsync(person).Wait();

            Assert.Equal("Parker", personRepository.GetBySurnameAsync("Parker").Result.surname);
            Assert.Equal(2, personRepository.GetBySurnameAsync("Parker").Result.Achievement.Count);
        }

        [Fact]
        public void TestUpdateDelete()
        {
            var testHelper = new TestHelper();
            var personRepository = testHelper.PersonRepository;
            var person = personRepository.GetBySurnameAsync("Potter").Result;
            personRepository.ChangeTrackerClear();
            person.Achievement.RemoveAt(0);

            personRepository.UpdateAsync(person).Wait();

            Assert.Equal(0, personRepository.GetBySurnameAsync("Potter").Result.Achievement.Count);
        }
    }
}