using Store_ASPnet_MVC.Data.Enums;
using Store_ASPnet_MVC.Models;

namespace Store_ASPnet_MVC.Data
{
    public class AppDBInitilizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviseScope = applicationBuilder.ApplicationServices.CreateScope())
            { 
                var context = serviseScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Беларусь",
                            Logo = "https://ms1.relax.by/images/c0d4b2ce6e61cb9e250b95abe518389a/resize/w=760,q=80/catalog_place_photo_default/6d/43/b4/6d43b480eefdba4a575a44c44c702c5c.jpg",
                            Description = "Описание первого кинотеатра"
                        },
                        new Cinema()
                        {
                            Name = "Берестье",
                            Logo = "https://rastishka.by/wp-content/uploads/berestje.jpg",
                            Description = "Описание второго кинотеатра"
                        },
                        new Cinema()
                        {
                            Name = "Silver Screen",
                            Logo = "https://content.onliner.by/news/2015/05/default/a9d06ef5ca98c783ef79ca3a105d4cc6.jpg",
                            Description = "Описание третьего кинотеатра"
                        },

                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Леонардо ДиКаприо",
                            Biography = "Биография первого актера",
                            PictureProfileURL = "https://pbs.twimg.com/media/EWdQi3fXkAM2s4a.jpg:large"
                        },
                        new Actor()
                        {
                            FullName = "Харрисон Форд",
                            Biography = "Биография второго актера",
                            PictureProfileURL = "https://pbs.twimg.com/media/E25B5m4UcAEIqnS.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Уилл Смит",
                            Biography = "Биография третьего актера",
                            PictureProfileURL = "https://s.yimg.com/uu/api/res/1.2/8FQYHGckUb3.A77znXD_pA--~B/aD0xMjAwO3c9MTIwMDthcHBpZD15dGFjaHlvbg--/https://media.zenfs.com/en/e__181/5d68eaccc13f9427ce6cdd255886c9e9"
                        },

                    });
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Квентин Тарантино",
                            Biography = "Биография первого режиссера",
                            PictureProfileURL = "https://www.dreadcentral.com/wp-content/uploads/2016/01/quentin.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Стивен Спилберг",
                            Biography = "Биография второго режиссера",
                            PictureProfileURL = "https://img.joinfo.com/i/2017/12/800x0/5a3b6b1360a1d.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Тони Скотт",
                            Biography = "Биография третьего режиссера",
                            PictureProfileURL = "https://static.vecer.com/images/slike/2012/08/20/ONLINE_091554-1300.JPG"
                        },

                    });
                    context.SaveChanges();

                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Индиана Джонс и Королевство хрустального черепа",
                            Description = "Описание первого фильма",
                            Price = 12,
                            ImageURL = "https://artfiles.alphacoders.com/979/97972.jpg",
                            StartDate = DateTime.Now.AddDays(6),
                            EndDate = DateTime.Now.AddDays(13),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Боевик
                        },
                        new Movie()
                        {
                            Name = "Однажды в… Голливуде",
                            Description = "Описание второго фильма",
                            Price = 15,
                            ImageURL = "https://ru-images.kinorium.com/movie/1080/1625804.jpg?1632474649",
                            StartDate = DateTime.Now.AddDays(-15),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Комедия
                        },
                        new Movie()
                        {
                            Name = "Враг государства",
                            Description = "Описание третьего фильма",
                            Price = 10,
                            ImageURL = "https://forums.goha.ru/cdn/forum/picture/129/129409.picture",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(4),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Триллер
                        },

                    });
                    context.SaveChanges();
                }
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
