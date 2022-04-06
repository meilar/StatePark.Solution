using Microsoft.EntityFrameworkCore.Migrations;

namespace StatePark.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Camping", "Name", "NearestCity", "Type" },
                values: new object[,]
                {
                    { 1, true, "Goose Lake State Recreation Area", "Lakeview", "Recreation Area" },
                    { 127, false, "Rooster Rock State Park", "Multnomah Falls", "State Park" },
                    { 128, false, "Bradley State Scenic Viewpoint", "Astoria", "Scenic Viewpoint" },
                    { 129, false, "Del Rey Beach State Recreation Site", "Gearhart", "Recreation Site" },
                    { 130, true, "Fort Stevens State Park", "Astoria", "State Park" },
                    { 131, false, "Cape Kiwanda State Natural Area", "Pacific City", "Natural Area" },
                    { 132, false, "Cape Meares State Scenic Viewpoint", "Tillamook", "Scenic Viewpoint" },
                    { 133, false, "Oceanside Beach State Recreation Site", "Tillamook", "Recreation Site" },
                    { 134, false, "Bob Straub State Park", "Pacific City", "State Park" },
                    { 135, true, "Cape Lookout State Park", "Tillamook", "State Park" },
                    { 126, false, "Wygant State Natural Area", "Hood River", "Natural Area" },
                    { 136, false, "Arcadia Beach State Recreation Site", "Cannon Beach", "Recreation Site" },
                    { 138, false, "Golden State Heritage Site", "Grants Pass", "Heritage Site" },
                    { 139, false, "Hug Point State Recreation Site", "Cannon Beach", "Recreation Site" },
                    { 140, false, "Manhattan Beach State Recreation Site", "Rockaway Beach", "Recreation Site" },
                    { 141, false, "Oswald West State Park", "Cannon Beach", "State Park" },
                    { 142, true, "Saddle Mountain State Natural Area", "Seaside", "Natural Area" },
                    { 143, false, "Tolovana Beach State Recreation Site", "Cannon Beach", "Recreation Site" },
                    { 144, true, "Nehalem Bay State Park", "Manzanita", "State Park" },
                    { 145, false, "Alsea Bay Historic Interpretive Center", "Waldport", "Interpretive Center" },
                    { 146, false, "Driftwood Beach State Recreation Site", "Waldport", "Recreation Site" },
                    { 137, false, "Ecola State Park", "Cannon Beach", "State Park" },
                    { 125, false, "Vinzenz Lausmann Memorial State Natural Area", "Hood River", "Natural Area" },
                    { 124, true, "Viento State Park", "Hood River", "State Park" },
                    { 123, false, "Starvation Creek State Park", "Hood River", "State Park" },
                    { 101, false, "Bonnie Lure State Recreation Area", "Estacada", "Recreation Area" },
                    { 103, true, "Milo McIver State Park", "Estacada", "State Park" },
                    { 104, false, "Tryon Creek State Natural Area", "Portland", "Natural Area" },
                    { 105, false, "Banks–Vernonia State Trail", "Vernonia", "State Trail" },
                    { 106, true, "Ainsworth State Park", "Multnomah Falls", "State Park" },
                    { 107, false, "Benson State Recreation Area", "Multnomah Falls", "Recreation Area" },
                    { 108, false, "Bridal Veil Falls State Scenic Viewpoint", "Multnomah Falls", "Scenic Viewpoint" },
                    { 109, false, "Crown Point State Scenic Corridor", "Troutdale", "Scenic Corridor" },
                    { 110, false, "Dabney State Recreation Area", "Troutdale", "Recreation Area" },
                    { 111, false, "George W. Joseph State Natural Area (accessible from Guy W. Talbot State Park)", "Troutdale", "Natural Area" },
                    { 112, false, "Guy W. Talbot State Park", "Troutdale", "State Park" },
                    { 113, false, "Historic Columbia River Highway State Trail", "Cascade Locks", "State Trail" },
                    { 114, false, "John B. Yeon State Scenic Corridor", "Cascade Locks", "Scenic Corridor" },
                    { 115, false, "Koberg Beach State Recreation Site", "Hood River", "Recreation Site" },
                    { 116, false, "Lewis and Clark State Recreation Site", "Troutdale", "Recreation Site" },
                    { 117, false, "Mayer State Park", "The Dalles", "State Park" },
                    { 118, true, "Memaloose State Park", "The Dalles", "State Park" },
                    { 119, false, "Portland Women's Forum State Scenic Viewpoint", "Troutdale", "Scenic Viewpoint" },
                    { 120, false, "Seneca Fouts Memorial State Natural Area", "Hood River", "Natural Area" },
                    { 121, false, "Shepperd's Dell State Natural Area", "Multnomah Falls", "Natural Area" },
                    { 122, false, "Sheridan State Scenic Corridor", "Cascade Locks", "Scenic Corridor" },
                    { 147, false, "Lost Creek State Recreation Site", "Newport", "Recreation Site" },
                    { 148, false, "Ona Beach State Park", "Newport", "State Park" },
                    { 149, false, "Seal Rock State Recreation Site", "Newport", "Recreation Site" },
                    { 150, false, "Yaquina Bay State Recreation Site", "Newport", "Recreation Site" },
                    { 176, false, "Jasper State Recreation Site", "Springfield", "Recreation Site" },
                    { 177, false, "Dexter State Recreation Site", "Springfield", "Recreation Site" },
                    { 178, false, "Munson Creek Falls State Natural Site", "Tillamook", "Natural Site" },
                    { 179, false, "Willamette Stone State Heritage Site", "Portland", "Heritage Site" },
                    { 180, false, "Umpqua State Scenic Corridor", "Reedsport", "Scenic Corridor" },
                    { 181, false, "Clay Myers State Natural Area at Whalen Island", "Pacific City", "Natural Area" },
                    { 182, false, "Fort Rock Cave (Near Fort Rock State Natural Area)", "Fort Rock", "National Historic Landmark" },
                    { 183, true, "Government Island State Recreation Area", "Portland", "Recreation Area" },
                    { 184, false, "Sunset Beach State Recreation Site", "Astoria", "Recreation Site" },
                    { 185, false, "Whale Watching Center", "Depoe Bay", "Guided Ocean Viewpoint" },
                    { 186, false, "Rocky Creek State Scenic Viewpoint", "Depoe Bay", "Scenic Viewpoint" },
                    { 187, false, "Fort Yamhill State Heritage Area", "Grand Ronde", "Heritage Area" },
                    { 188, true, "L. L. 'Stub' Stewart State Park", "Vernonia", "State Park" },
                    { 189, false, "Thompson's Mills State Heritage Site", "Shedd", "Heritage Site" },
                    { 190, false, "State Capitol State Park", "Salem", "State Park" },
                    { 191, false, "Arizona Beach State Recreation Site", "Port Orford", "Recreation Site" },
                    { 192, false, "Bates State Park", "Prairie City", "State Park" },
                    { 193, false, "Ochoco State Scenic Viewpoint", "Prineville", "Scenic Viewpoint" },
                    { 194, false, "Dyer State Wayside", "Condon", "Wayside" },
                    { 195, false, "Pete French Round Barn State Heritage Site", "New Princeton", "Heritage Site" },
                    { 196, false, "Cottonwood Canyon State Park", "Moro", "State Park" },
                    { 175, false, "Lowell State Recreation Site", "Springfield", "Recreation Site" },
                    { 100, false, "Willamette Mission State Park", "Salem", "State Park" },
                    { 174, true, "Fall Creek State Recreation Site", "Springfield", "Recreation Site" },
                    { 172, false, "Battle Mountain Forest State Scenic Corridor", "Ukiah", "Scenic Corridor" },
                    { 151, true, "South Beach State Park", "Newport", "State Park" },
                    { 152, true, "Cascadia State Park", "Sweet Home", "State Park" },
                    { 153, true, "Silver Falls State Park", "Silverton", "State Park" },
                    { 154, false, "Agate Beach State Recreation Site", "Newport", "Recreation Site" },
                    { 155, false, "Boiler Bay State Scenic Viewpoint", "Depoe Bay", "Scenic Viewpoint" },
                    { 156, false, "D River State Recreation Site", "Lincoln City", "Recreation Site" },
                    { 157, true, "Devils Lake State Recreation Area", "Lincoln City", "Recreation Area" },
                    { 158, false, "Devils Punch Bowl State Natural Area", "Newport", "Natural Area" },
                    { 159, false, "Ellmaker State Wayside", "Newport", "Wayside" },
                    { 160, false, "Fogarty Creek State Recreation Area", "Depoe Bay", "Recreation Area" },
                    { 161, false, "Gleneden Beach State Recreation Site", "Lincoln City", "Recreation Area" },
                    { 162, false, "H. B. Van Duzer Forest State Scenic Corridor", "Lincoln City", "Scenic Corridor" },
                    { 163, false, "Neskowin Beach State Recreation Site", "Neskowin", "Recreation Site" },
                    { 164, false, "Otter Crest State Scenic Viewpoint", "Newport", "Scenic Viewpoint" },
                    { 165, false, "Roads End State Recreation Site", "Lincoln City", "Recreation Site" },
                    { 166, true, "Beverly Beach State Park", "Newport", "State Park" },
                    { 167, true, "Collier Memorial State Park", "Klamath Falls", "State Park" },
                    { 168, true, "Jackson F. Kimball State Recreation Site", "Fort Klamath", "Recreation Site" },
                    { 169, false, "OC&E Woods Line State Trail", "Klamath Falls", "State Trail" },
                    { 170, false, "South Jetty (South Beach)", "Newport", "Beach Access" },
                    { 171, false, "Blue Mountain Forest State Scenic Corridor", "La Grande", "Scenic Corridor" },
                    { 173, false, "Sumpter Valley Dredge State Heritage Area", "Baker City", "Heritage Area" },
                    { 99, false, "Sarah Helmick State Recreation Site", "Monmouth", "Recreation Site" },
                    { 102, false, "Mary S. Young State Recreation Area", "West Linn", "Recreation Area" },
                    { 97, false, "Holman State Wayside", "Salem", "Wayside" },
                    { 27, true, "Prineville Reservoir State Park", "Prineville", "State Park" },
                    { 28, false, "Heritage Landing (Deschutes)", "The Dalles", "Boat Launch" },
                    { 29, false, "White River Falls State Park", "The Dalles", "State Park" },
                    { 30, true, "Deschutes River State Recreation Area", "The Dalles", "Recreation Area" },
                    { 31, false, "Cline Falls State Scenic Viewpoint", "Redmond", "Scenic Viewpoint" },
                    { 32, true, "Fort Rock State Natural Area", "Fort Rock", "Natural Area" },
                    { 33, true, "La Pine State Park", "La Pine", "State Park" },
                    { 34, false, "Pilot Butte State Scenic Viewpoint", "Bend", "Scenic Viewpoint" },
                    { 35, true, "Tumalo State Park", "Bend", "State Park" },
                    { 36, false, "Peter Skene Ogden State Scenic Viewpoint", "Redmond", "Scenic Viewpoint" },
                    { 37, true, "Smith Rock State Park", "Redmond", "State Park" },
                    { 38, false, "Booth State Scenic Corridor", "Lakeview", "Scenic Corridor" },
                    { 39, false, "Chandler State Wayside", "Lakeview", "Wayside" },
                    { 40, false, "Geisel Monument State Heritage Site", "Gold Beach", "Heritage Site" },
                    { 41, true, "Humbug Mountain State Park", "Port Orford", "State Park" },
                    { 42, false, "Otter Point State Recreation Site", "Gold Beach", "Recreation Site" },
                    { 43, false, "Paradise Point State Recreation Site", "Port Orford", "Recreation Site" },
                    { 44, false, "Port Orford Heads State Park", "Port Orford", "State Park" },
                    { 45, true, "Cape Blanco State Park", "Port Orford", "State Park" },
                    { 98, false, "Maud Williamson State Recreation Site", "Salem", "Recreation Site" },
                    { 47, false, "Coquille Myrtle Grove State Natural Site", "Myrtle Point", "Natural Site" },
                    { 26, true, "Jasper Point Campground", "Prineville", "Campground" },
                    { 48, false, "Face Rock State Scenic Viewpoint", "Bandon", "Scenic Viewpoint" },
                    { 25, true, "The Cove Palisades State Park", "Madras", "State Park" },
                    { 23, false, "Prospect State Scenic Viewpoint", "Prospect", "Scenic Viewpoint" },
                    { 2, false, "Frenchglen Hotel State Heritage Site", "Burns", "Heritage Site" },
                    { 3, false, "Ontario State Recreation Site", "Ontario", "Recreation Site" },
                    { 4, true, "Farewell Bend State Recreation Area", "Ontario", "Recreation Area" },
                    { 5, false, "Kam Wah Chung State Heritage Site", "John Day", "Heritage Site" },
                    { 6, false, "Unity Forest State Scenic Corridor", "John Day", "Scenic Corridor" },
                    { 7, true, "Unity Lake State Recreation Site", "John Day", "Recreation Site" },
                    { 8, true, "Clyde Holliday State Recreation Site", "John Day", "Recreation Site" },
                    { 9, true, "Succor Creek State Natural Area", "Nyssa", "Natural Area" },
                    { 10, true, "Lake Owyhee State Park", "Nyssa", "State Park" },
                    { 11, true, "Catherine Creek State Park", "Union", "State Park" },
                    { 12, false, "Hat Rock State Park", "Umatilla", "State Park" },
                    { 13, true, "Hilgard Junction State Recreation Area", "La Grande", "Recreation Area" },
                    { 14, true, "Red Bridge State Wayside", "La Grande", "Wayside" },
                    { 15, true, "Ukiah–Dale Forest State Scenic Corridor", "Ukiah", "Scenic Corridor" },
                    { 16, true, "Emigrant Springs State Heritage Area", "Pendleton", "Heritage Area" },
                    { 17, false, "Wallowa Lake Highway Forest State Scenic Corridor", "Enterprise", "Scenic Corridor" },
                    { 18, false, "Wallowa River Rest Area", "La Grande", "Rest Area" },
                    { 19, true, "Minam State Recreation Area", "Elgin", "Recreation Area" },
                    { 20, true, "Wallowa Lake State Recreation Area", "Joseph", "Recreation Area" },
                    { 21, false, "Iwetemlaykin State Heritage Site", "Joseph", "Heritage Site" },
                    { 22, false, "Casey State Recreation Site", "Medford", "Recreation Site" },
                    { 24, true, "Joseph H. Stewart State Recreation Area", "Medford", "Recreation Area" },
                    { 49, false, "Hoffman Memorial State Wayside", "Myrtle Point", "Wayside" },
                    { 46, false, "Bandon State Natural Area", "Bandon", "Natural Area" },
                    { 51, true, "Bullards Beach State Park", "Bandon", "State Park" },
                    { 77, false, "Molalla River State Park", "Canby", "State Park" },
                    { 50, false, "Seven Devils State Recreation Site", "Bandon", "Recreation Site" },
                    { 79, false, "Beaver Creek State Natural Area", "Newport", "State Park" },
                    { 80, false, "Bolon Island Tideways State Scenic Corridor", "Reedsport", "Scenic Corridor" },
                    { 81, false, "Darlingtonia State Natural Site", "Florence", "Natural Site" },
                    { 82, false, "Governor Patterson Memorial State Recreation Site", "Waldport", "Recreation Site" },
                    { 83, true, "Umpqua Lighthouse State Park", "Reedsport", "State Park" },
                    { 84, true, "Beachside State Recreation Site", "Waldport", "Recreation Site" },
                    { 85, true, "Carl G. Washburne Memorial State Park", "Florence", "State Park" },
                    { 76, false, "Bald Peak State Scenic Viewpoint", "Newberg", "Scenic Viewpoint" },
                    { 86, false, "Heceta Head Lighthouse State Scenic Viewpoint", "Florence", "Scenic Viewpoint" },
                    { 88, false, "Neptune State Scenic Viewpoint", "Yachats", "Scenic Viewpoint" },
                    { 89, false, "Smelt Sands State Recreation Site", "Yachats", "Recreation Site" },
                    { 90, false, "Tokatee Klootchman State Natural Site", "Florence", "Natural Site" },
                    { 91, false, "Stonefield Beach State Recreation Site", "Yachats", "Recreation Site" },
                    { 92, false, "W. B. Nelson State Recreation Site", "Waldport", "Recreation Site" },
                    { 93, false, "Yachats Ocean Road State Natural Site", "Yachats", "Natural Site" },
                    { 94, false, "Yachats State Recreation Area", "Yachats", "Recreation Area" },
                    { 95, true, "Jessie M. Honeyman Memorial State Park", "Florence", "State Park" },
                    { 96, false, "Erratic Rock State Natural Site", "Sheridan", "Natural Site" },
                    { 87, false, "Muriel O. Ponsler Memorial State Scenic Viewpoint", "Florence", "Scenic Viewpoint" },
                    { 75, true, "Valley of the Rogue State Recreation Area", "Grants Pass", "Recreation Area" },
                    { 78, true, "Champoeg State Heritage Area", "Newberg", "Heritage Area" },
                    { 73, false, "Tub Springs State Wayside", "Ashland", "Wayside" },
                    { 52, true, "Alfred A. Loeb State Park", "Brookings", "State Park" },
                    { 53, false, "Cape Sebastian State Scenic Corridor", "Gold Beach", "Scenic Corridor" },
                    { 54, false, "Crissey Field State Recreation Site", "Brookings", "Recreation Site" },
                    { 55, false, "McVay Rock State Recreation Site", "Brookings", "Recreation Site" },
                    { 56, false, "Pistol River State Scenic Viewpoint", "Gold Beach", "Scenic Viewpoint" },
                    { 57, false, "Samuel H. Boardman State Scenic Corridor", "Brookings", "Scenic Corridor" },
                    { 74, false, "Wolf Creek Inn State Heritage Site", "Grants Pass", "Heritage Site" },
                    { 59, true, "Harris Beach State Recreation Area", "Brookings", "Recreation Area" },
                    { 60, false, "Alderwood State Wayside", "Junction City", "Wayside" },
                    { 61, false, "Elijah Bristow State Park", "Eugene", "State Park" },
                    { 58, false, "Winchuck State Recreation Site", "Brookings", "Recreation Site" },
                    { 63, false, "Mongold Day-Use Area", "Detroit", "Boat Launch" },
                    { 64, false, "North Santiam State Recreation Area", "Mill City", "Recreation Area" },
                    { 65, true, "Detroit Lake State Recreation Area", "Detroit", "Recreation Area" },
                    { 66, false, "Cape Arago State Park", "Coos Bay", "State Park" },
                    { 67, false, "Golden and Silver Falls State Natural Area", "Coos Bay", "Natural Area" },
                    { 68, false, "Shore Acres State Park", "Coos Bay", "State Park" },
                    { 69, true, "William M. Tugman State Park", "Reedsport", "State Park" },
                    { 70, true, "Sunset Bay State Park", "Coos Bay", "State Park" },
                    { 71, false, "Illinois River Forks State Park", "Cave Junction", "State Park" },
                    { 62, false, "Washburne State Wayside", "Junction City", "Wayside" },
                    { 72, false, "TouVelle State Recreation Site", "Medford", "Recreation Site" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[,]
                {
                    { 6, "Willamette Valley" },
                    { 5, "South Coast" },
                    { 4, "Portland/Columbia Gorge" },
                    { 7, "Central Coast" },
                    { 2, "Eastern Oregon" },
                    { 1, "Southern Oregon" },
                    { 3, "Central Oregon" },
                    { 8, "North Coast" }
                });

            migrationBuilder.InsertData(
                table: "ParkRegions",
                columns: new[] { "ParkRegionId", "ParkId", "RegionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 126, 98, 6 },
                    { 127, 99, 6 },
                    { 128, 100, 6 },
                    { 129, 152, 6 },
                    { 130, 153, 6 },
                    { 131, 174, 6 },
                    { 132, 175, 6 },
                    { 133, 176, 6 },
                    { 134, 177, 6 },
                    { 125, 97, 6 },
                    { 135, 187, 6 },
                    { 137, 190, 6 },
                    { 138, 79, 7 },
                    { 139, 80, 7 },
                    { 140, 81, 7 },
                    { 141, 82, 7 },
                    { 142, 83, 7 },
                    { 143, 84, 7 },
                    { 144, 85, 7 },
                    { 145, 86, 7 },
                    { 136, 189, 6 },
                    { 124, 96, 6 },
                    { 123, 78, 6 },
                    { 122, 65, 6 },
                    { 101, 51, 5 },
                    { 102, 52, 5 },
                    { 103, 53, 5 },
                    { 104, 54, 5 },
                    { 105, 55, 5 },
                    { 106, 56, 5 },
                    { 107, 57, 5 },
                    { 108, 58, 5 },
                    { 109, 59, 5 },
                    { 110, 66, 5 },
                    { 111, 67, 5 },
                    { 112, 68, 5 },
                    { 113, 69, 5 },
                    { 114, 70, 5 },
                    { 115, 180, 5 },
                    { 116, 191, 5 },
                    { 117, 60, 6 },
                    { 118, 61, 6 },
                    { 119, 62, 6 },
                    { 120, 63, 6 },
                    { 121, 64, 6 },
                    { 146, 87, 7 },
                    { 147, 88, 7 },
                    { 148, 89, 7 },
                    { 149, 90, 7 },
                    { 175, 130, 8 },
                    { 176, 131, 8 },
                    { 177, 132, 8 },
                    { 178, 133, 8 },
                    { 179, 134, 8 },
                    { 180, 135, 8 },
                    { 181, 136, 8 },
                    { 182, 137, 8 },
                    { 183, 139, 8 },
                    { 184, 140, 8 },
                    { 185, 141, 8 },
                    { 186, 142, 8 },
                    { 187, 143, 8 },
                    { 188, 144, 8 },
                    { 189, 156, 8 },
                    { 190, 157, 8 },
                    { 191, 162, 8 },
                    { 192, 163, 8 },
                    { 193, 165, 8 },
                    { 194, 178, 8 },
                    { 195, 181, 8 },
                    { 174, 129, 8 },
                    { 100, 50, 5 },
                    { 173, 128, 8 },
                    { 171, 185, 7 },
                    { 150, 91, 7 },
                    { 151, 92, 7 },
                    { 152, 93, 7 },
                    { 153, 94, 7 },
                    { 154, 95, 7 },
                    { 155, 145, 7 },
                    { 156, 146, 7 },
                    { 157, 147, 7 },
                    { 158, 148, 7 },
                    { 159, 149, 7 },
                    { 160, 150, 7 },
                    { 161, 151, 7 },
                    { 162, 154, 7 },
                    { 163, 155, 7 },
                    { 164, 158, 7 },
                    { 165, 159, 7 },
                    { 166, 160, 7 },
                    { 167, 161, 7 },
                    { 168, 164, 7 },
                    { 169, 166, 7 },
                    { 170, 170, 7 },
                    { 172, 186, 7 },
                    { 196, 184, 8 },
                    { 99, 49, 5 },
                    { 97, 47, 5 },
                    { 27, 13, 2 },
                    { 28, 14, 2 },
                    { 29, 15, 2 },
                    { 30, 16, 2 },
                    { 31, 17, 2 },
                    { 32, 18, 2 },
                    { 33, 19, 2 },
                    { 34, 20, 2 },
                    { 35, 21, 2 },
                    { 26, 12, 2 },
                    { 36, 171, 2 },
                    { 38, 173, 2 },
                    { 39, 192, 2 },
                    { 40, 194, 2 },
                    { 41, 195, 2 },
                    { 42, 25, 3 },
                    { 43, 26, 3 },
                    { 44, 27, 3 },
                    { 45, 31, 3 },
                    { 46, 32, 3 },
                    { 37, 172, 2 },
                    { 25, 11, 2 },
                    { 24, 10, 2 },
                    { 23, 9, 2 },
                    { 2, 22, 1 },
                    { 3, 23, 1 },
                    { 4, 24, 1 },
                    { 5, 38, 1 },
                    { 6, 39, 1 },
                    { 7, 71, 1 },
                    { 8, 72, 1 },
                    { 9, 73, 1 },
                    { 10, 74, 1 },
                    { 11, 75, 1 },
                    { 12, 138, 1 },
                    { 13, 167, 1 },
                    { 14, 168, 1 },
                    { 15, 169, 1 },
                    { 16, 2, 2 },
                    { 17, 3, 2 },
                    { 18, 4, 2 },
                    { 19, 5, 2 },
                    { 20, 6, 2 },
                    { 21, 7, 2 },
                    { 22, 8, 2 },
                    { 47, 33, 3 },
                    { 48, 34, 3 },
                    { 49, 35, 3 },
                    { 50, 36, 3 },
                    { 76, 117, 4 },
                    { 77, 118, 4 },
                    { 78, 119, 4 },
                    { 79, 120, 4 },
                    { 80, 121, 4 },
                    { 81, 122, 4 },
                    { 82, 123, 4 },
                    { 83, 124, 4 },
                    { 84, 125, 4 },
                    { 85, 126, 4 },
                    { 86, 127, 4 },
                    { 87, 179, 4 },
                    { 88, 183, 4 },
                    { 89, 188, 4 },
                    { 90, 40, 5 },
                    { 91, 41, 5 },
                    { 92, 42, 5 },
                    { 93, 43, 5 },
                    { 94, 44, 5 },
                    { 95, 45, 5 },
                    { 96, 46, 5 },
                    { 75, 116, 4 },
                    { 98, 48, 5 },
                    { 74, 115, 4 },
                    { 72, 113, 4 },
                    { 51, 37, 3 },
                    { 52, 182, 3 },
                    { 53, 193, 3 },
                    { 54, 196, 3 },
                    { 55, 28, 4 },
                    { 56, 29, 4 },
                    { 57, 30, 4 },
                    { 58, 76, 4 },
                    { 59, 77, 4 },
                    { 60, 101, 4 },
                    { 61, 102, 4 },
                    { 62, 103, 4 },
                    { 63, 104, 4 },
                    { 64, 105, 4 },
                    { 65, 106, 4 },
                    { 66, 107, 4 },
                    { 67, 108, 4 },
                    { 68, 109, 4 },
                    { 69, 110, 4 },
                    { 70, 111, 4 },
                    { 71, 112, 4 },
                    { 73, 114, 4 },
                    { 197, 197, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ParkRegions",
                keyColumn: "ParkRegionId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 8);
        }
    }
}
