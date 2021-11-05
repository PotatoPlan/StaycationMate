namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedAttractionsThumbnails : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/GreatOceanRoad.jpg', Alternative_Text='Great Ocean Road' WHERE Id = 4");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/NationalGalleryofVictoria.jpg', Alternative_Text='National Gallery of Victoria' WHERE Id = 5");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/GrampiansNationalPark.jpg', Alternative_Text='Grampians National Park' WHERE Id = 6");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/QueenVictoriaMarket.jpg', Alternative_Text='Queen Victoria Market' WHERE Id = 7");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/EurekaSkydeck.jpg', Alternative_Text='Eureka Skydeck' WHERE Id = 8");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MelbourneZoo.jpg', Alternative_Text='Melbourne Zoo' WHERE Id = 9");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MelbourneMuseum.jpeg', Alternative_Text='Melbourne Museum' WHERE Id = 10");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/WerribeeOpenRangeZoo.jpg', Alternative_Text='Werribee Open Range Zoo' WHERE Id = 11");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MountHotham.jpg', Alternative_Text='Mount Hotham' WHERE Id = 12");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/PortCampbellNationalPark.jpg', Alternative_Text='Port Campbell National Park' WHERE Id = 13");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/GreatOtwayNationalPark.jpg', Alternative_Text='Great Otway National Park' WHERE Id = 14");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/AlpineNationalPark.jpg', Alternative_Text='Alpine National Park' WHERE Id = 15");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/CapeOtwayLightstation.jpg', Alternative_Text='Cape Otway Lightstation' WHERE Id = 16");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/FitzroyGardens.jpg', Alternative_Text='Fitzroy Gardens' WHERE Id = 17");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MountBawBaw.jpg', Alternative_Text='Mount Baw Baw' WHERE Id = 18");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/PeninsulaHotSprings.jpg', Alternative_Text='Peninsula Hot Springs' WHERE Id = 19");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MountBuffaloNationalPark.jpg', Alternative_Text='Mount Buffalo National Park' WHERE Id = 20");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/AlbertParkLake.jpg', Alternative_Text='Albert Park Lake' WHERE Id = 21");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/PhillipIslandWildlifePark.jpg', Alternative_Text='Phillip Island Wildlife Park' WHERE Id = 22");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/BallaratWildlifePark.jpg', Alternative_Text='Ballarat Wildlife Park' WHERE Id = 23");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MountBuller.jpg', Alternative_Text='Mount Buller' WHERE Id = 24");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/CroajingolongNationalPark.jpg', Alternative_Text='Croajingolong National Park' WHERE Id = 25");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/Tarra-BulgaNationalPark.jpg', Alternative_Text='Tarra-Bulga National Park' WHERE Id = 26");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/BendigoArtGallery.jpg', Alternative_Text='Bendigo Art Gallery' WHERE Id = 27");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/GeelongBotanicGardens.jpg', Alternative_Text='Geelong Botanic Gardens' WHERE Id = 28");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MountBogong.jpg', Alternative_Text='Mount Bogong' WHERE Id = 29");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/OrganPipesNationalPark.jpg', Alternative_Text='Organ Pipes National Park' WHERE Id = 30");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/KinglakeNationalPark.jpg', Alternative_Text='Kinglake National Park' WHERE Id = 31");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MountStirling.jpg', Alternative_Text='Mount Stirling' WHERE Id = 32");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/GeelongGallery.jpg', Alternative_Text='Geelong Gallery' WHERE Id = 33");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/YarraRangesNationalPark.jpg', Alternative_Text='Yarra Ranges National Park' WHERE Id = 34");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/AltonaBeach.jpeg', Alternative_Text='Altona Beach' WHERE Id = 35");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/WarrandyteStatePark.jpg', Alternative_Text='Warrandyte State Park' WHERE Id = 36");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/ElwoodBeach.jpg', Alternative_Text='Elwood Beach' WHERE Id = 37");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/RedHillEstate.jpg', Alternative_Text='Red Hill Estate' WHERE Id = 38");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/SheppartonArtMuseum.jpg', Alternative_Text='Shepparton Art Museum' WHERE Id = 39");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MorningtonPeninsulaNationalPark.jpg', Alternative_Text='Mornington Peninsula National Park' WHERE Id = 40");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/EurekaCentreBallarat.jpg', Alternative_Text='Eureka Centre Ballarat' WHERE Id = 41");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MainRidgeEstate.jpeg', Alternative_Text='Main Ridge Estate' WHERE Id = 42");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/WyperfeldNationalPark.jpg', Alternative_Text='Wyperfeld National Park' WHERE Id = 43");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/TheYouYangs.jpg', Alternative_Text='The You Yangs' WHERE Id = 44");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/BarmahNationalPark.jpg', Alternative_Text='Barmah National Park' WHERE Id = 45");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/StKildaBotanicalGardens.jpg', Alternative_Text='St Kilda Botanical Gardens' WHERE Id = 46");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/LilydaleLake.jpg', Alternative_Text='Lilydale Lake' WHERE Id = 47");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/WerribeeGorgeStatePark.jpg', Alternative_Text='Werribee Gorge State Park' WHERE Id = 48");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/LakeWendouree.jpg', Alternative_Text='Lake Wendouree' WHERE Id = 49");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/HangingRockWinery.jpg', Alternative_Text='Hanging Rock Winery' WHERE Id = 50");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/WineYarraValley.jpg', Alternative_Text='Wine Yarra Valley' WHERE Id = 51");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/MitcheltonWines.jpg', Alternative_Text='Mitchelton Wines' WHERE Id = 52");
            Sql("UPDATE Attractions SET Thumbnail='~/Content/Thumbnails/SuttonGrangeWinery.jpg', Alternative_Text='Sutton Grange Winery' WHERE Id = 53");

        }

        public override void Down()
        {
        }
    }
}
