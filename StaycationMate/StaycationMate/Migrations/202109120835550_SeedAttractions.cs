namespace StaycationMate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedAttractions : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Great Ocean Road', 'Great Ocean Road', 'Port Campbell', 'Victoria', '3269', -38.733826, 143.687271)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('National Gallery of Victoria', '180 St Kilda Rd', 'Melbourne', 'Victoria', '3006', -37.8226, 144.9689)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Grampians National Park', 'Grampians National Park', 'Glenisla', 'Victoria', '3314', -37.2109, 142.3980)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Queen Victoria Market', 'Queen St', 'Melbourne', 'Victoria', '3000', -37.8076, 144.9568)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Eureka Skydeck', '7 Riverside Quay, Southbank', 'Melbourne', 'Victoria', '3006', -37.8213, 144.9647)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Melbourne Zoo', 'Elliott Ave, Parkville', 'Melbourne', 'Victoria', '3052', -37.7841, 144.9515)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Melbourne Museum', '11 Nicholson St, Carlton', 'Melbourne', 'Victoria', '3052', -37.8033, 144.9717)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Werribee Open Range Zoo', 'K Rd, Werribee South', 'Melbourne', 'Victoria', '3030', -37.9227, 144.6672)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mount Hotham', 'Hotham Heights', 'Hotham Heights', 'Victoria', '3741', -36.9753, 147.1328)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Port Campbell National Park', 'Great Ocean Rd', 'Port Campbell', 'Victoria', '3269', -38.6621, 143.1050)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Great Otway National Park', 'Great Otway National Park', 'Cape Otway', 'Victoria', '3233', -38.7912, 143.5419)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Alpine National Park', 'Mountain Creek Rd', 'Tawonga', 'Victoria', '3699', -36.6858, 147.2451)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Cape Otway Lightstation', 'Otway, Lighthouse Rd', 'Cape Otway', 'Victoria', '3233', -38.8566, 143.5117)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Fitzroy Gardens', 'Wellington Parade', 'Melbourne', 'Victoria', '3002', -37.8127, 144.9801)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mount Baw Baw', 'Baw Baw Village', 'Baw Baw Village', 'Victoria', '3833', -37.8383, 146.2736)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Peninsula Hot Springs', '140 Springs Ln', 'Fingal', 'Victoria', '3939', -38.4069, 144.8427)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mount Buffalo National Park', 'Mount Buffalo Rd', 'Mount Buffalo', 'Victoria', '3740', -36.7552, 146.7911)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Albert Park Lake', 'Albert Park', 'Melbourne', 'Victoria', '3206', -37.8443, 144.9688)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Phillip Island Wildlife Park', '2115 Phillip Island Rd', 'Cowes', 'Victoria', '3922', -38.4736, 145.2388)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Ballarat Wildlife Park', '250 Fussell St', 'Ballarat', 'Victoria', '3350', -37.5699, 143.8927)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mount Buller', 'Mount Buller', 'Mount Buller', 'Victoria', '3723', -37.1468, 146.4490)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Croajingolong National Park', 'W Wingan Rd', 'Wingan River', 'Victoria', '3891', -37.7415, 149.4980)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Tarra-Bulga National Park', 'Grand Ridge Rd', 'Balook', 'Victoria', '3971', -38.4291, 146.5669)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Bendigo Art Gallery', '42 View St', 'Bendigo', 'Victoria', '3550', -36.7575, 144.2764)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Geelong Botanic Gardens', 'Corner of Eastern Park Circuit &, Podbury Dr', 'Geelong', 'Victoria', '3219', -38.1490, 144.3758)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mount Bogong', 'Tawonga', 'Tawonga', 'Victoria', '3697', -36.7322, 147.3058)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Organ Pipes National Park', 'Organ Pipes Rd', 'Keilor North', 'Victoria', '3036', -37.6674, 144.7657)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Kinglake National Park', 'Masons Falls Rd', 'Kinglake West', 'Victoria', '3757', -37.4934, 145.2504)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mount Stirling', 'Mount Buller', 'Mount Buller', 'Victoria', '3723', -37.1272, 146.4989)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Geelong Gallery', '55 Little Malop St', 'Geelong', 'Victoria', '3220', -38.1472, 144.3569)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Yarra Ranges National Park', 'Lockwood Rd', 'Reefton', 'Victoria', '3799', -37.6828, 145.9787)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Altona Beach', 'Esplanade', 'Altona', 'Victoria', '3018', -37.8710, 144.8300)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Warrandyte State Park', 'Pound Bend Rd', 'Warrandyte', 'Victoria', '3113', -37.7289, 145.2435)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Elwood Beach', '2/33 Scott St', 'Elwood', 'Victoria', '3184', -37.8902, 144.9846)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Red Hill Estate', '53 Shoreham Rd', 'Red Hill South', 'Victoria', '3937', -38.4025, 145.0166)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Shepparton Art Museum', '530 Wyndham St', 'Shepparton', 'Victoria', '3630', -36.3912, 145.3969)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mornington Peninsula National Park', 'Cape Schanck Rd', 'Cape Schanck', 'Victoria', '3939', -38.4914, 144.8881)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Eureka Centre Ballarat', '102 Stawell St S', 'Ballarat', 'Victoria', '3350', -37.5650, 143.8839)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Main Ridge Estate', '80 William Rd', 'Red Hill', 'Victoria', '3937', -38.3691, 144.9862)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Wyperfeld National Park', 'Wyperfeld Entrance Rd', 'Yaapeet', 'Victoria', '3424', -35.5865, 142.0511)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('The You Yangs', 'Little River', 'Little River', 'Victoria', '3211', -37.9328, 144.4319)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Barmah National Park', 'Sand Ridge Track', 'Barmah', 'Victoria', '3639', -35.9611, 144.9582)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('St Kilda Botanical Gardens', '11 Herbert St', 'Melbourne', 'Victoria', '3182', -37.8709, 144.9840)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Lilydale Lake', 'Lilydale', 'Lilydale', 'Victoria', '3140', -37.7651, 145.3551)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Werribee Gorge State Park', '204 Myers Rd', 'Pentland Hills', 'Victoria', '3341', -37.6631, 144.3632)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Lake Wendouree', 'Lake Wendouree', 'Ballarat', 'Victoria', '3350', -37.5490, 143.8470)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Hanging Rock Winery', '88 Jim Rd', 'Newham', 'Victoria', '3442', -37.3088, 144.5838)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Wine Yarra Valley', '177 Maroondah Hwy', 'Healesville', 'Victoria', '3777', -37.6542, 145.5143)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Mitchelton Wines', '470 Mitchellstown Rd', 'Nagambie', 'Victoria', '3608', -36.8490, 145.0904)");
            Sql("INSERT INTO Attractions(Location_Name, Street_Address, City, State, Postal_Code, Latitude, Longitude) VALUES('Sutton Grange Winery', '1 Carnochans Rd', 'Sutton Grange', 'Victoria', '3448', -36.9577, 144.3537)");
        }

        public override void Down()
        {
        }
    }
}
