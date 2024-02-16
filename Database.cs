using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace progetto_settimanaleS15L5
{
    public static class Database
    {
        public static List<Prodotto> GetProdotti()
        {
            List<Prodotto> prodotti = new List<Prodotto> {
                new Prodotto {
                    IdProdotto = 1, Nome = "Scarpe da corsa Nike Air Zoom Pegasus 38", Descrizione = "Scarpe da corsa adatte a lunghe distanze", Prezzo = 129.99m, ImgUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/e2ff01fa-7e97-4536-b4f8-a9f21992cba3/scarpa-da-running-su-strada-pegasus-38-5HVSDm.png"
                },
                new Prodotto {
                    IdProdotto = 2, Nome = "Pantaloni da corsa Adidas Own the Run", Descrizione = "Pantaloni leggeri e traspiranti per la corsa", Prezzo = 39.99m, ImgUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/dab8f703f34f4500ac45ad1d0138cc38_9366/Pantaloni_adidas_Own_The_Run_Astro_Wind_Nero_H13238_21_model.jpg"
                },
                new Prodotto {
                    IdProdotto = 3, Nome = "Maglia da calcio Nike FC Barcelona", Descrizione = "Maglia ufficiale della squadra FC Barcelona", Prezzo = 89.99m, ImgUrl = "https://img01.ztat.net/article/spp-media-p1/8e3605d72a7a497890cd5e860bb8bae6/d0de1e645f0743548034efb9556f04a4.jpg?imwidth=1800&filter=packshot"
                },
                new Prodotto {
                    IdProdotto = 4, Nome = "Pallone da calcio Adidas UEFA Champions League", Descrizione = "Pallone ufficiale della UEFA Champions League", Prezzo = 29.99m, ImgUrl = "https://www.futbolemotion.com/imagesarticulos/197933/750/balon-adidas-ucl-com-blanco-0.webp"
                },
                new Prodotto {
                    IdProdotto = 5, Nome = "Tuta da ginnastica Puma Amplified", Descrizione = "Tuta comoda e resistente per l'allenamento", Prezzo = 79.99m, ImgUrl = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_600,h_600/global/679730/14/fnd/EEA/fmt/png/Tuta-PUMA-POWER-da-uomo"
                },
                new Prodotto {
                    IdProdotto = 6, Nome = "Pallavolo Mikasa V200W", Descrizione = "Pallone ufficiale della Federazione Internazionale di Pallavolo", Prezzo = 69.99m, ImgUrl = "https://www.tradeinn.com/f/14058/140581031/mikasa-palla-pallavolo-v200w.jpg"
                },
                new Prodotto {
                    IdProdotto = 7, Nome = "Scarpe da basket Adidas Harden Vol. 5", Descrizione = "Scarpe da basket ad alte prestazioni", Prezzo = 149.99m, ImgUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/89bb935fc29e415ba9778732fcb73be6_9366/Scarpe_D.O.N._Issue_5_Turchese_IE8325_01_standard.jpg"
                },
                new Prodotto {
                    IdProdotto = 8, Nome = "Giubbino da corsa Nike Essential", Descrizione = "Giubbino leggero e resistente all'acqua", Prezzo = 79.99m, ImgUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/d0cd6a2a-de3c-4c24-aeb6-c1b3eadce2aa/giacca-da-running-repel-windrunner-wrm13g.png"
                },
                new Prodotto {
                    IdProdotto = 9, Nome = "Guanti da portiere Adidas Predator 20", Descrizione = "Guanti da portiere con tecnologia Predator Grip", Prezzo = 49.99m, ImgUrl = "https://www.portierecalcio.it/cdn/shop/files/guanti-portiere-adidas-predator-pro-own-your-football.jpg?v=1691659573&width=1125"
                },
                new Prodotto {
                    IdProdotto = 10, Nome = "Felpa con cappuccio Under Armour Rival", Descrizione = "Felpa in pile calda e confortevole", Prezzo = 59.99m, ImgUrl = "https://img01.ztat.net/article/spp-media-p1/9d828c5169604b2fa5e2e03fca2ff39d/90904626969b4dd59c2d2237329d7d4f.jpg?imwidth=1800&filter=packshot"
                },
                new Prodotto {
                    IdProdotto = 11, Nome = "Cyclette da casa NordicTrack S22i", Descrizione = "Cyclette con schermo touchscreen e accesso a lezioni online", Prezzo = 1999.99m, ImgUrl = "https://webidoostore.com/cdn/shop/files/NTEX02422_01_1600.jpg?v=1705939838&width=1200"
                },
                new Prodotto {
                    IdProdotto = 12, Nome = "Materasso da yoga Liforme", Descrizione = "Materasso antiscivolo e ecologico per praticare yoga", Prezzo = 129.99m, ImgUrl = "https://m.media-amazon.com/images/I/51rBXN4W9VS._AC_SX679_.jpg"
                },
                new Prodotto {
                    IdProdotto = 13, Nome = "Pattini in linea Rollerblade Zetrablade", Descrizione = "Pattini in linea comodi e facili da usare per principianti", Prezzo = 99.99m, ImgUrl = "https://m.media-amazon.com/images/I/615ZJswXljL._AC_SX679_.jpg"
                },
                new Prodotto {
                    IdProdotto = 14, Nome = "Tappetino per il fitness BalanceFrom", Descrizione = "Tappetino spesso e resistente per esercizi a casa", Prezzo = 29.99m, ImgUrl = "https://m.media-amazon.com/images/I/51qoQLAjcmL._AC_SX679_.jpg"
                },
                new Prodotto {
                    IdProdotto = 15, Nome = "T-shirt da corsa New Balance Accelerate", Descrizione = "T-shirt traspirante per la corsa e l'allenamento", Prezzo = 24.99m, ImgUrl = "https://www.tradeinn.com/f/13871/138714396/new-balance-maglietta-a-maniche-corte-core.jpg"
                },
                new Prodotto {
                    IdProdotto = 16, Nome = "Mazza da tennis Wilson Pro Staff", Descrizione = "Mazza da tennis di alta qualità per giocatori esperti", Prezzo = 199.99m, ImgUrl = "https://www.tennis-point.it/dw/image/v2/BBDP_PRD/on/demandware.static/-/Sites-master-catalog/default/dw4f9f5472/images/007/051/03579000_000.jpg?q=80&sw=570"
                },
                new Prodotto {
                    IdProdotto = 17, Nome = "Muta da surf Rip Curl Dawn Patrol", Descrizione = "Muta in neoprene per surfisti di livello intermedio", Prezzo = 199.99m, ImgUrl = "https://cdn.watersportsoutlet.com/images/1x1/thumbs/2023%20Rip%20Curl%20Mens%20Dawn%20Patrol%20Eco%20Performance%2043mm%20GBS%20Chest%20Zip%20Wetsuit%2015DMFS%20-%20Navy%20main.700x700.jpg"
                },
                new Prodotto {
                    IdProdotto = 18, Nome = "Casco da ciclismo Giro Fixture", Descrizione = "Casco leggero e ventilato per ciclisti urbani", Prezzo = 49.99m, ImgUrl = "https://www.tradeinn.com/f/13776/137761910/giro-casco-mtb-fixture.jpg"
                },
                new Prodotto {
                    IdProdotto = 19, Nome = "Palla da tennis Wilson US Open", Descrizione = "Palla da tennis ufficiale dello US Open", Prezzo = 9.99m, ImgUrl = "https://www.tennis-point.it/dw/image/v2/BBDP_PRD/on/demandware.static/-/Sites-master-catalog/default/dw6f4250da/images/007/226/0153800000_000.jpg?q=80&sw=570"
                },
                new Prodotto {
                    IdProdotto = 20, Nome = "Zaino da trekking Osprey Atmos AG 65", Descrizione = "Zaino ergonomico con sistema di supporto anti-vibrazione", Prezzo = 299.99m, ImgUrl = "https://www.osprey.com/gb/media/catalog/product/cache/63b3a82c3ac11f4453e22cee6fc03260/a/t/atmosag65_s22_side_mythicalgreen.jpg"
                }
            };

            return prodotti;
        }

        public static Prodotto GetProdottoById(int productId)
        {
            List<Prodotto> prodotti = GetProdotti();
            return prodotti.FirstOrDefault(p => p.IdProdotto == productId);
        }


    }
}