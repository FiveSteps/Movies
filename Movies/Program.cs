using System;

namespace Movies
{
    class Program
    {

        class Movie
        {
            private string movieName;
            private string movieGenre;

            //Свойства класса
            public string MovieName
            {
                get { return movieName; }
                set
                {
                    if (movieName != "") movieName = value;
                }
            }

            public string MovieGenre
            {
                get { return movieGenre; }
                set
                {
                    if (movieGenre != "") movieGenre = value;
                }
            }

            //Конструкторы класса
            public Movie() { }

            public Movie(int Choose, string MovieName) 
            {
                if (Choose == 1) movieName = MovieName;
            }

            public Movie(string MovieGenre)
            {
                movieGenre = MovieGenre;
            }

            public Movie(string MovieName, string MovieGenre) 
            {
                movieName = MovieName;
                movieGenre = MovieGenre;
            }

            //Методы класса
            public void ShowMovieInfo()
            {
                Console.WriteLine("Название фильма: " + MovieName + "\n" +
                               "Жанр: " + MovieGenre + "\n");
            }

            public void MakeYourOwnMovie(string MovieName, string MovieGenre, double Budget, string LeadingActor)
            {
                Console.WriteLine("Вы решили снять фильм под названием " + MovieName + "\n" +
                                    "В жанре: " + MovieGenre + "\n" + 
                                    "С бюджетом: " + Budget + " Рублей" + "\n" +
                                    "В главной роли: " + LeadingActor + "\n");
            }

            public void GiveAnOscarToSomebody(string ActorName)
            {
                Console.WriteLine("Актёр по имени " + ActorName + " получил оскар\n");
            }
        }

        class Horror : Movie
        {
            private string leadingActorName;
            private double horrorMovieRating;

            //Свойства класса
            public string LeadingActorName
            {
                get { return leadingActorName; }
                set
                {
                    if (leadingActorName != "") leadingActorName = value;
                }
            }

            public double HorrorMovieRating
            {
                get { return horrorMovieRating; }
                set
                {
                    if (horrorMovieRating > 0) horrorMovieRating = value;
                }
            }

            //Конструкторы класса
            public Horror() { }

            public Horror(string LeadingActorName)
            {
                leadingActorName = LeadingActorName;
            }
            
            public Horror(double HorrorMovieRating)
            {
                horrorMovieRating = HorrorMovieRating;
            }
            
            public Horror(string LeadingActorName, double HorrorMovieRating)
            {
                leadingActorName = LeadingActorName;
                horrorMovieRating = HorrorMovieRating;
            }

            //Методы класса
            public void ShowHorrorInfo()
            {
                Console.WriteLine("Имя главного актёра: " + leadingActorName + "\n" +
                                   "Рейтинг фильма: " + horrorMovieRating + "\n");
            }

            public void ToScareTheViewer(double PercentOfViewerYouTryToScare)
            {
                Console.WriteLine("Вы напугали " + PercentOfViewerYouTryToScare + "% ваших зрителей\n");
            }

            public void CriticsQuotes(string Quotes)
            {
                Console.WriteLine("Отзывы критиков о данном фильме: " + Quotes + "\n");
            }
        }

        class Actors : Movie
        {
            private int numberOfActors;
            private string cast;

            //Свойства класса
            public int NumberOfActors
            {
                get { return numberOfActors; }
                set
                {
                    if (numberOfActors > 0) numberOfActors = value;
                }
            }

            public string Cast
            {
                get { return cast; }
                set
                {
                    if (cast != "") cast = value;
                }
            }

            //Конструкторы класса
            public Actors() { }

            public Actors(int NumberOfActors)
            {
                numberOfActors = NumberOfActors;
            } 
            
            public Actors(string Cast)
            {
                cast = Cast;
            }
            
            public Actors(int NumberOfActors, string Cast)
            {
                numberOfActors = NumberOfActors;
                cast = Cast;
            }

            //Методы класса
            public void ShowActorsInfo()
            {
                Console.WriteLine("Количество актёров: " + numberOfActors + "\n" +
                                  "Актёрский состав: " + Cast + "\n");
            }

            public void ToTakeAPhotoWithActor(bool DoYouWantIt)
            {
                if (DoYouWantIt == true) Console.WriteLine("Вы попытались сделать фото с одним из " +
                                                            "актёров фильма и у вас получилось!\n");
                else Console.WriteLine("Вы даже не попытались сделать фото с любимым актёром\n");
            }

            public void ToStarInAMovie(string ChooseMovie)
            {
                Console.WriteLine("Вы считаете себя настоящим актёром и решаете сняться в фильме " + 
                                    ChooseMovie + " быть может у вас что-нибудь получится");
            }
        }

        static void Main(string[] args)
        {
            //Объекты
            Movie movie = new Movie("Джокер", "Драма/Криминальный фильм");
            Horror horror = new Horror("Джек Николсон", 7.3);
            Actors actor = new Actors(4, "Уолтер Уайт, Дженнифер Энистон, Эштон Катчер, Сирша Ронан");

            //Методы и свойства
            Console.WriteLine("Название фильма: " + movie.MovieName + "\n" +
                               "Жанр: " + movie.MovieGenre + "\n");
            Console.WriteLine("/////Методы для работы с классом Movie/////");
            movie.ShowMovieInfo();
            movie.MakeYourOwnMovie("Шахта", "Хоррор", 20_000_000, "Мэтт Деймон");
            movie.GiveAnOscarToSomebody("Хоакин Феникс");

            Console.WriteLine("/////Методы для работы с классом Horror/////");
            horror.ShowHorrorInfo();
            horror.ToScareTheViewer(76);
            horror.CriticsQuotes("\n1)Это истинный экзестенциальный шедевр \n" +
                                "2)Начало очень интригует\n" +
                                "3)Это удивительно пугающий хоррор\n");

            Console.WriteLine("/////Методы для работы с классом Actor/////");
            actor.ShowActorsInfo();
            actor.ToTakeAPhotoWithActor(true);
            actor.ToStarInAMovie("Горбатая гора");
        }
    }
}
