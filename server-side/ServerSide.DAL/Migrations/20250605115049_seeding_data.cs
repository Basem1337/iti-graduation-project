using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerSide.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeding_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c0000001-0000-0000-0000-000000000001"), "Immersive role-playing games with deep stories and character development.", "RPG" },
                    { new Guid("c0000001-0000-0000-0000-000000000002"), "Exciting games combining action sequences with exploration and puzzle-solving.", "Action-Adventure" },
                    { new Guid("c0000001-0000-0000-0000-000000000003"), "Games blending fast-paced action combat with role-playing game elements.", "Action RPG" },
                    { new Guid("c0000001-0000-0000-0000-000000000004"), "Vast open worlds filled with action, exploration, and freedom.", "Open-World, Action" },
                    { new Guid("c0000001-0000-0000-0000-000000000005"), "First-person shooter games focusing on gun-based combat.", "FPS" },
                    { new Guid("c0000001-0000-0000-0000-000000000006"), "Games that combine terrifying horror elements with action gameplay.", "Horror, Action" },
                    { new Guid("c0000001-0000-0000-0000-000000000007"), "Narrative-driven games focused on exploration and puzzle-solving.", "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Company", "Description", "Discount", "FinalPrice", "Name", "OriginalPrice", "Rate", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { new Guid("a0000000-0000-0000-0000-000000000001"), new Guid("c0000001-0000-0000-0000-000000000001"), "CD Projekt Red", "A story-driven open-world RPG set in a visually stunning fantasy universe full of meaningful choices and impactful consequences.", 0m, 39.99m, "The Witcher 3: Wild Hunt", 39.99m, 0m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/uqtFg2C2v_0?si=TeCSyxNtpSwpW3OG" },
                    { new Guid("a0000000-0000-0000-0000-000000000002"), new Guid("c0000001-0000-0000-0000-000000000002"), "Rockstar Games", "An epic tale of life in America’s unforgiving heartland, with an immersive open-world experience and stunning storytelling.", 0m, 59.99m, "Red Dead Redemption 2", 59.99m, 0m, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/eaW0tYpxyp0?si=fR3PIiSDuBNYnmAb" },
                    { new Guid("a0000000-0000-0000-0000-000000000003"), new Guid("c0000001-0000-0000-0000-000000000003"), "CD Projekt Red", "A futuristic open-world RPG set in Night City, where you play as a mercenary outlaw seeking a unique implant granting immortality.", 0m, 49.99m, "Cyberpunk 2077", 49.99m, 0m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/8X2kIfS6fb8?si=Jws9zAr7BK4Z4c8C" },
                    { new Guid("a0000000-0000-0000-0000-000000000004"), new Guid("c0000001-0000-0000-0000-000000000003"), "FromSoftware", "An expansive fantasy action RPG with rich lore, open-world exploration, and challenging combat mechanics.", 0m, 59.99m, "Elden Ring", 59.99m, 0m, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/K_03kFqWfqs?si=9QifFRcb_8GsrF1d" },
                    { new Guid("a0000000-0000-0000-0000-000000000005"), new Guid("c0000001-0000-0000-0000-000000000002"), "Santa Monica Studio", "Follow Kratos and his son, Atreus, on a journey through Norse mythology in a breathtaking and emotional adventure.", 0m, 49.99m, "God of War (2018)", 49.99m, 0m, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/K0u_kAWLJOA?si=kErVde8OKkV87IVY" },
                    { new Guid("a0000000-0000-0000-0000-000000000006"), new Guid("c0000001-0000-0000-0000-000000000004"), "Rockstar Games", "A vast open world of crime, heists, and exploration, following three protagonists in Los Santos.", 0m, 29.99m, "Grand Theft Auto V", 29.99m, 0m, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/QkkoHAzjnUs?si=dAf546sunfutA0Wd" },
                    { new Guid("a0000000-0000-0000-0000-000000000007"), new Guid("c0000001-0000-0000-0000-000000000003"), "Ubisoft", "Play as a Viking raider exploring and conquering Anglo-Saxon England.", 0m, 59.99m, "Assassin’s Creed Valhalla", 59.99m, 0m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/ssrNcwxALS4?si=nXuA34zE-32jKyyW" },
                    { new Guid("a0000000-0000-0000-0000-000000000008"), new Guid("c0000001-0000-0000-0000-000000000005"), "Activision", "A high-action military shooter with a cinematic campaign and thrilling multiplayer.", 0m, 69.99m, "Call of Duty: Modern Warfare II", 69.99m, 0m, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/ztjfwecrY8E?si=-jgRpUqwxSG_Nbmo" },
                    { new Guid("a0000000-0000-0000-0000-000000000009"), new Guid("c0000001-0000-0000-0000-000000000005"), "Electronic Arts", "A large-scale military shooter set in the near future with massive multiplayer battles.", 0m, 49.99m, "Battlefield 2042", 49.99m, 0m, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/ASzOzrB-a9E?si=F2e6ZgqP28TVlj81" },
                    { new Guid("a0000000-0000-0000-0000-000000000010"), new Guid("c0000001-0000-0000-0000-000000000006"), "Capcom", "A terrifying and immersive survival horror experience set in a mysterious village.", 0m, 39.99m, "Resident Evil Village", 39.99m, 0m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/tjfTxFzGh3Q?si=IfWAOWUcWbnvu8ih" },
                    { new Guid("a0000000-0000-0000-0000-000000000011"), new Guid("c0000001-0000-0000-0000-000000000005"), "343 Industries", "The latest chapter in the Halo franchise featuring an open-world campaign and multiplayer battles.", 0m, 59.99m, "Halo Infinite", 59.99m, 0m, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/rFh2i4AlPD4?si=HrtzxEY5oeLryzx1" },
                    { new Guid("a0000000-0000-0000-0000-000000000012"), new Guid("c0000001-0000-0000-0000-000000000003"), "FromSoftware", "A dark and atmospheric action RPG with challenging gameplay and deep lore.", 0m, 49.99m, "Dark Souls III", 49.99m, 0m, new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/_zDZYrIUgKE?si=6d6Bh6a17ZkowNgH" },
                    { new Guid("a0000000-0000-0000-0000-000000000013"), new Guid("c0000001-0000-0000-0000-000000000007"), "Kojima Productions", "A unique open-world experience about connecting a fractured society through delivery missions.", 0m, 39.99m, "Death Stranding", 39.99m, 0m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/Mpn-MC2B6Zc?si=MIci5C_lhy5mrBEY" },
                    { new Guid("a0000000-0000-0000-0000-000000000014"), new Guid("c0000001-0000-0000-0000-000000000003"), "Guerrilla Games", "Explore a post-apocalyptic world filled with robotic creatures and uncover ancient secrets.", 0m, 69.99m, "Horizon Forbidden West", 69.99m, 0m, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/XLZN63UxAOM?si=DAwFG2SjXJ6C6idp" },
                    { new Guid("a0000000-0000-0000-0000-000000000015"), new Guid("c0000001-0000-0000-0000-000000000002"), "Insomniac Games", "Swing through New York City as Spider-Man in a cinematic and action-packed story.", 0m, 49.99m, "Marvel’s Spider-Man", 49.99m, 0m, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/3R2uvJqWeVg?si=QJ0sDGcFdCg4Lmqd" },
                    { new Guid("a0000000-0000-0000-0000-000000000016"), new Guid("c0000001-0000-0000-0000-000000000003"), "FromSoftware", "A fast-paced samurai action game with deep combat mechanics and a gripping story.", 0m, 59.99m, "Sekiro: Shadows Die Twice", 59.99m, 0m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/rXMX4YJ7Lks?si=sFB-MIVCG1laKJ82" },
                    { new Guid("a0000000-0000-0000-0000-000000000017"), new Guid("c0000001-0000-0000-0000-000000000002"), "Respawn Entertainment", "A Star Wars action RPG where you play as a Jedi surviving in a post-Order 66 world.", 0m, 69.99m, "Star Wars Jedi: Survivor", 69.99m, 0m, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/VRaobDJjiec?si=cI9W2luLBw0Rea3r" },
                    { new Guid("a0000000-0000-0000-0000-000000000018"), new Guid("c0000001-0000-0000-0000-000000000002"), "Naughty Dog", "A gripping and emotional narrative-driven experience set in a post-apocalyptic world.", 0m, 59.99m, "The Last of Us Part II", 59.99m, 0m, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/vhII1qlcZ4E?si=rVV7pNU9V7IwBc3t" },
                    { new Guid("a0000000-0000-0000-0000-000000000019"), new Guid("c0000001-0000-0000-0000-000000000005"), "id Software", "A high-speed, brutal shooter where you battle demons across multiple dimensions.", 0m, 39.99m, "Doom Eternal", 39.99m, 0m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/_UuktemkCFI?si=vpM4t0KZtLmComDO" },
                    { new Guid("a0000000-0000-0000-0000-000000000020"), new Guid("c0000001-0000-0000-0000-000000000003"), "Capcom", "A co-op action RPG where you hunt massive monsters and craft powerful gear.", 0m, 29.99m, "Monster Hunter: World", 29.99m, 0m, new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/Ro6r15wzp2o?si=3qsaSwk1w21OEmmz" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("b0000000-0000-0000-0000-000000000001"), new Guid("a0000000-0000-0000-0000-000000000001"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785148/The_Witcher_3__Wild_Hunt_veizjq.webp" },
                    { new Guid("b0000000-0000-0000-0000-000000000002"), new Guid("a0000000-0000-0000-0000-000000000002"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785143/Red_Dead_Redemption_2_ajzbne.webp" },
                    { new Guid("b0000000-0000-0000-0000-000000000003"), new Guid("a0000000-0000-0000-0000-000000000003"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785135/Cyberpunk_2077_mpcrn7.webp" },
                    { new Guid("b0000000-0000-0000-0000-000000000004"), new Guid("a0000000-0000-0000-0000-000000000004"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785143/Elden_Ring_z76bf2.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000005"), new Guid("a0000000-0000-0000-0000-000000000005"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785134/God_of_War_2018_bqgg9r.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000006"), new Guid("a0000000-0000-0000-0000-000000000006"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785138/Grand_Theft_Auto_V_pc1m1w.png" },
                    { new Guid("b0000000-0000-0000-0000-000000000007"), new Guid("a0000000-0000-0000-0000-000000000007"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785134/Assassin_s_Creed_Valhalla_nmbjgk.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000008"), new Guid("a0000000-0000-0000-0000-000000000008"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785136/Call_of_Duty_Modern_Warfare_II_-_Copy_oxel4a.webp" },
                    { new Guid("b0000000-0000-0000-0000-000000000009"), new Guid("a0000000-0000-0000-0000-000000000009"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785134/Battlefield_2042_-_Copy_mfd3z3.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000010"), new Guid("a0000000-0000-0000-0000-000000000010"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785148/Resident_Evil_Village_jyj7c1.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000011"), new Guid("a0000000-0000-0000-0000-000000000011"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785139/Halo_Infinite_xc86o8.png" },
                    { new Guid("b0000000-0000-0000-0000-000000000012"), new Guid("a0000000-0000-0000-0000-000000000012"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785146/Dark_Souls_III_ddwqhw.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000013"), new Guid("a0000000-0000-0000-0000-000000000013"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785143/Death_Stranding_epmymd.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000014"), new Guid("a0000000-0000-0000-0000-000000000014"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785140/Horizon_Forbidden_West_r9dxp6.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000015"), new Guid("a0000000-0000-0000-0000-000000000015"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785138/Marvel_s_Spider-Man_hu3pi4.webp" },
                    { new Guid("b0000000-0000-0000-0000-000000000016"), new Guid("a0000000-0000-0000-0000-000000000016"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785146/Sekiro_Shadows_Die_Twice_f5gpjv.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000017"), new Guid("a0000000-0000-0000-0000-000000000017"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785144/Star_Wars_Jedi_Survivor_jurhq6.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000018"), new Guid("a0000000-0000-0000-0000-000000000018"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785144/The_Last_of_Us_Part_II_zifqwd.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000019"), new Guid("a0000000-0000-0000-0000-000000000019"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785140/Doom_Eternal_cifdng.jpg" },
                    { new Guid("b0000000-0000-0000-0000-000000000020"), new Guid("a0000000-0000-0000-0000-000000000020"), "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785140/Monster_Hunter_World_acr9c5.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("b0000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000007"));
        }
    }
}
