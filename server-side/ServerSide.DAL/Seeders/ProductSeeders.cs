using System;
using System.Collections.Generic;
using System.Globalization;
using ServerSide.DAL.Models; // Make sure your Product, Category, and Photo models are in this namespace

/*
ASSUMPTIONS:
1. Your `ServerSide.DAL.Models.Photo` class looks something like this:
   public class Photo
   {
       public Guid Id { get; set; }
       public string Url { get; set; } = string.Empty;
       public Guid ProductId { get; set; } // Foreign key to Product
       // public virtual Product Product { get; set; } // Optional navigation property
   }

2. Your `ServerSide.DAL.Models.Product` class has the `TrailerUrl` property
   and other properties as shown in your last version of the code.
   (The `Rate` property is still omitted as per your last code).
*/

public static class ProductSeeder
{
    // Updated return type to include a list of Photos
    public static (List<Product> Products, List<Category> Categories, List<Photo> AllPhotos) SeedData()
    {
        // Category GUIDs (These are valid)
        var rpgCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000001");
        var actionAdventureCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000002");
        var actionRpgCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000003");
        var openWorldActionCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000004");
        var fpsCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000005");
        var horrorActionCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000006");
        var adventureCategoryId = Guid.Parse("c0000001-0000-0000-0000-000000000007");

        var categories = new List<Category>
        {
            new Category { Id = rpgCategoryId, Name = "RPG", Description = "Immersive role-playing games with deep stories and character development." },
            new Category { Id = actionAdventureCategoryId, Name = "Action-Adventure", Description = "Exciting games combining action sequences with exploration and puzzle-solving." },
            new Category { Id = actionRpgCategoryId, Name = "Action RPG", Description = "Games blending fast-paced action combat with role-playing game elements." },
            new Category { Id = openWorldActionCategoryId, Name = "Open-World, Action", Description = "Vast open worlds filled with action, exploration, and freedom." },
            new Category { Id = fpsCategoryId, Name = "FPS", Description = "First-person shooter games focusing on gun-based combat." },
            new Category { Id = horrorActionCategoryId, Name = "Horror, Action", Description = "Games that combine terrifying horror elements with action gameplay." },
            new Category { Id = adventureCategoryId, Name = "Adventure", Description = "Narrative-driven games focused on exploration and puzzle-solving." }
        };

        var products = new List<Product>();
        var allPhotos = new List<Photo>();

        // Product 1: The Witcher 3: Wild Hunt
        var product1Id = Guid.Parse("A0000000-0000-0000-0000-000000000001");
        products.Add(new Product
        {
            Id = product1Id,
            Name = "The Witcher 3: Wild Hunt",
            Description = "A story-driven open-world RPG set in a visually stunning fantasy universe full of meaningful choices and impactful consequences.",
            OriginalPrice = 39.99m,
            Discount = 0m,
            FinalPrice = 39.99m,
            Company = "CD Projekt Red",
            TrailerUrl = "https://youtu.be/uqtFg2C2v_0?si=TeCSyxNtpSwpW3OG",
            ReleaseDate = new DateTime(2015, 5, 19),
            CategoryId = rpgCategoryId
            // Photos collection is NOT initialized here for HasData
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000001"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785148/The_Witcher_3__Wild_Hunt_veizjq.webp",
            ProductId = product1Id // Set the foreign key
        });

        // Product 2: Red Dead Redemption 2
        var product2Id = Guid.Parse("A0000000-0000-0000-0000-000000000002");
        products.Add(new Product
        {
            Id = product2Id,
            Name = "Red Dead Redemption 2",
            Description = "An epic tale of life in America’s unforgiving heartland, with an immersive open-world experience and stunning storytelling.",
            OriginalPrice = 59.99m,
            Discount = 0m,
            FinalPrice = 59.99m,
            Company = "Rockstar Games",
            TrailerUrl = "https://youtu.be/eaW0tYpxyp0?si=fR3PIiSDuBNYnmAb",
            ReleaseDate = new DateTime(2018, 10, 26),
            CategoryId = actionAdventureCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000002"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785143/Red_Dead_Redemption_2_ajzbne.webp",
            ProductId = product2Id
        });

        // Product 3: Cyberpunk 2077
        var product3Id = Guid.Parse("A0000000-0000-0000-0000-000000000003");
        products.Add(new Product
        {
            Id = product3Id,
            Name = "Cyberpunk 2077",
            Description = "A futuristic open-world RPG set in Night City, where you play as a mercenary outlaw seeking a unique implant granting immortality.",
            OriginalPrice = 49.99m,
            Discount = 0m,
            FinalPrice = 49.99m,
            Company = "CD Projekt Red",
            TrailerUrl = "https://youtu.be/8X2kIfS6fb8?si=Jws9zAr7BK4Z4c8C",
            ReleaseDate = new DateTime(2020, 12, 10),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000003"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785135/Cyberpunk_2077_mpcrn7.webp",
            ProductId = product3Id
        });

        // Product 4: Elden Ring
        var product4Id = Guid.Parse("A0000000-0000-0000-0000-000000000004");
        products.Add(new Product
        {
            Id = product4Id,
            Name = "Elden Ring",
            Description = "An expansive fantasy action RPG with rich lore, open-world exploration, and challenging combat mechanics.",
            OriginalPrice = 59.99m,
            Discount = 0m,
            FinalPrice = 59.99m,
            Company = "FromSoftware",
            TrailerUrl = "https://youtu.be/K_03kFqWfqs?si=9QifFRcb_8GsrF1d",
            ReleaseDate = new DateTime(2022, 2, 25),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000004"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785143/Elden_Ring_z76bf2.jpg",
            ProductId = product4Id
        });

        // Product 5: God of War (2018)
        var product5Id = Guid.Parse("A0000000-0000-0000-0000-000000000005");
        products.Add(new Product
        {
            Id = product5Id,
            Name = "God of War (2018)",
            Description = "Follow Kratos and his son, Atreus, on a journey through Norse mythology in a breathtaking and emotional adventure.",
            OriginalPrice = 49.99m,
            Discount = 0m,
            FinalPrice = 49.99m,
            Company = "Santa Monica Studio",
            TrailerUrl = "https://youtu.be/K0u_kAWLJOA?si=kErVde8OKkV87IVY",
            ReleaseDate = new DateTime(2018, 4, 20),
            CategoryId = actionAdventureCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000005"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785134/God_of_War_2018_bqgg9r.jpg",
            ProductId = product5Id
        });

        // Product 6: Grand Theft Auto V
        var product6Id = Guid.Parse("A0000000-0000-0000-0000-000000000006");
        products.Add(new Product
        {
            Id = product6Id,
            Name = "Grand Theft Auto V",
            Description = "A vast open world of crime, heists, and exploration, following three protagonists in Los Santos.",
            OriginalPrice = 29.99m,
            Discount = 0m,
            FinalPrice = 29.99m,
            Company = "Rockstar Games",
            TrailerUrl = "https://youtu.be/QkkoHAzjnUs?si=dAf546sunfutA0Wd",
            ReleaseDate = new DateTime(2013, 9, 17),
            CategoryId = openWorldActionCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000006"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785138/Grand_Theft_Auto_V_pc1m1w.png",
            ProductId = product6Id
        });

        // Product 7: Assassin’s Creed Valhalla
        var product7Id = Guid.Parse("A0000000-0000-0000-0000-000000000007");
        products.Add(new Product
        {
            Id = product7Id,
            Name = "Assassin’s Creed Valhalla",
            Description = "Play as a Viking raider exploring and conquering Anglo-Saxon England.",
            OriginalPrice = 59.99m,
            Discount = 0m,
            FinalPrice = 59.99m,
            Company = "Ubisoft",
            TrailerUrl = "https://youtu.be/ssrNcwxALS4?si=nXuA34zE-32jKyyW",
            ReleaseDate = new DateTime(2020, 11, 10),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000007"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785134/Assassin_s_Creed_Valhalla_nmbjgk.jpg",
            ProductId = product7Id
        });

        // Product 8: Call of Duty: Modern Warfare II
        var product8Id = Guid.Parse("A0000000-0000-0000-0000-000000000008");
        products.Add(new Product
        {
            Id = product8Id,
            Name = "Call of Duty: Modern Warfare II",
            Description = "A high-action military shooter with a cinematic campaign and thrilling multiplayer.",
            OriginalPrice = 69.99m,
            Discount = 0m,
            FinalPrice = 69.99m,
            Company = "Activision",
            TrailerUrl = "https://youtu.be/ztjfwecrY8E?si=-jgRpUqwxSG_Nbmo",
            ReleaseDate = new DateTime(2022, 10, 28),
            CategoryId = fpsCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000008"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785136/Call_of_Duty_Modern_Warfare_II_-_Copy_oxel4a.webp",
            ProductId = product8Id
        });

        // Product 9: Battlefield 2042
        var product9Id = Guid.Parse("A0000000-0000-0000-0000-000000000009");
        products.Add(new Product
        {
            Id = product9Id,
            Name = "Battlefield 2042",
            Description = "A large-scale military shooter set in the near future with massive multiplayer battles.",
            OriginalPrice = 49.99m,
            Discount = 0m,
            FinalPrice = 49.99m,
            Company = "Electronic Arts",
            TrailerUrl = "https://youtu.be/ASzOzrB-a9E?si=F2e6ZgqP28TVlj81",
            ReleaseDate = new DateTime(2021, 11, 19),
            CategoryId = fpsCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000009"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785134/Battlefield_2042_-_Copy_mfd3z3.jpg",
            ProductId = product9Id
        });

        // Product 10: Resident Evil Village
        var product10Id = Guid.Parse("A0000000-0000-0000-0000-000000000010");
        products.Add(new Product
        {
            Id = product10Id,
            Name = "Resident Evil Village",
            Description = "A terrifying and immersive survival horror experience set in a mysterious village.",
            OriginalPrice = 39.99m,
            Discount = 0m,
            FinalPrice = 39.99m,
            Company = "Capcom",
            TrailerUrl = "https://youtu.be/tjfTxFzGh3Q?si=IfWAOWUcWbnvu8ih",
            ReleaseDate = new DateTime(2021, 5, 7),
            CategoryId = horrorActionCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000010"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785148/Resident_Evil_Village_jyj7c1.jpg",
            ProductId = product10Id
        });

        // Product 11: Halo Infinite
        var product11Id = Guid.Parse("A0000000-0000-0000-0000-000000000011");
        products.Add(new Product
        {
            Id = product11Id,
            Name = "Halo Infinite",
            Description = "The latest chapter in the Halo franchise featuring an open-world campaign and multiplayer battles.",
            OriginalPrice = 59.99m,
            Discount = 0m,
            FinalPrice = 59.99m,
            Company = "343 Industries",
            TrailerUrl = "https://youtu.be/rFh2i4AlPD4?si=HrtzxEY5oeLryzx1",
            ReleaseDate = new DateTime(2021, 12, 8),
            CategoryId = fpsCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000011"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785139/Halo_Infinite_xc86o8.png",
            ProductId = product11Id
        });

        // Product 12: Dark Souls III
        var product12Id = Guid.Parse("A0000000-0000-0000-0000-000000000012");
        products.Add(new Product
        {
            Id = product12Id,
            Name = "Dark Souls III",
            Description = "A dark and atmospheric action RPG with challenging gameplay and deep lore.",
            OriginalPrice = 49.99m,
            Discount = 0m,
            FinalPrice = 49.99m,
            Company = "FromSoftware",
            TrailerUrl = "https://youtu.be/_zDZYrIUgKE?si=6d6Bh6a17ZkowNgH",
            ReleaseDate = new DateTime(2016, 3, 24),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000012"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785146/Dark_Souls_III_ddwqhw.jpg",
            ProductId = product12Id
        });

        // Product 13: Death Stranding
        var product13Id = Guid.Parse("A0000000-0000-0000-0000-000000000013");
        products.Add(new Product
        {
            Id = product13Id,
            Name = "Death Stranding",
            Description = "A unique open-world experience about connecting a fractured society through delivery missions.",
            OriginalPrice = 39.99m,
            Discount = 0m,
            FinalPrice = 39.99m,
            Company = "Kojima Productions",
            TrailerUrl = "https://youtu.be/Mpn-MC2B6Zc?si=MIci5C_lhy5mrBEY",
            ReleaseDate = new DateTime(2019, 11, 8),
            CategoryId = adventureCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000013"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785143/Death_Stranding_epmymd.jpg",
            ProductId = product13Id
        });

        // Product 14: Horizon Forbidden West
        var product14Id = Guid.Parse("A0000000-0000-0000-0000-000000000014");
        products.Add(new Product
        {
            Id = product14Id,
            Name = "Horizon Forbidden West",
            Description = "Explore a post-apocalyptic world filled with robotic creatures and uncover ancient secrets.",
            OriginalPrice = 69.99m,
            Discount = 0m,
            FinalPrice = 69.99m,
            Company = "Guerrilla Games",
            TrailerUrl = "https://youtu.be/XLZN63UxAOM?si=DAwFG2SjXJ6C6idp",
            ReleaseDate = new DateTime(2022, 2, 18),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000014"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785140/Horizon_Forbidden_West_r9dxp6.jpg",
            ProductId = product14Id
        });

        // Product 15: Marvel’s Spider-Man
        var product15Id = Guid.Parse("A0000000-0000-0000-0000-000000000015");
        products.Add(new Product
        {
            Id = product15Id,
            Name = "Marvel’s Spider-Man",
            Description = "Swing through New York City as Spider-Man in a cinematic and action-packed story.",
            OriginalPrice = 49.99m,
            Discount = 0m,
            FinalPrice = 49.99m,
            Company = "Insomniac Games",
            TrailerUrl = "https://youtu.be/3R2uvJqWeVg?si=QJ0sDGcFdCg4Lmqd",
            ReleaseDate = new DateTime(2018, 9, 7),
            CategoryId = actionAdventureCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000015"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785138/Marvel_s_Spider-Man_hu3pi4.webp",
            ProductId = product15Id
        });

        // Product 16: Sekiro: Shadows Die Twice
        var product16Id = Guid.Parse("A0000000-0000-0000-0000-000000000016");
        products.Add(new Product
        {
            Id = product16Id,
            Name = "Sekiro: Shadows Die Twice",
            Description = "A fast-paced samurai action game with deep combat mechanics and a gripping story.",
            OriginalPrice = 59.99m,
            Discount = 0m,
            FinalPrice = 59.99m,
            Company = "FromSoftware",
            TrailerUrl = "https://youtu.be/rXMX4YJ7Lks?si=sFB-MIVCG1laKJ82",
            ReleaseDate = new DateTime(2019, 3, 22),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000016"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785146/Sekiro_Shadows_Die_Twice_f5gpjv.jpg",
            ProductId = product16Id
        });

        // Product 17: Star Wars Jedi: Survivor
        var product17Id = Guid.Parse("A0000000-0000-0000-0000-000000000017");
        products.Add(new Product
        {
            Id = product17Id,
            Name = "Star Wars Jedi: Survivor",
            Description = "A Star Wars action RPG where you play as a Jedi surviving in a post-Order 66 world.",
            OriginalPrice = 69.99m,
            Discount = 0m,
            FinalPrice = 69.99m,
            Company = "Respawn Entertainment",
            TrailerUrl = "https://youtu.be/VRaobDJjiec?si=cI9W2luLBw0Rea3r",
            ReleaseDate = new DateTime(2023, 4, 28),
            CategoryId = actionAdventureCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000017"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785144/Star_Wars_Jedi_Survivor_jurhq6.jpg",
            ProductId = product17Id
        });

        // Product 18: The Last of Us Part II
        var product18Id = Guid.Parse("A0000000-0000-0000-0000-000000000018");
        products.Add(new Product
        {
            Id = product18Id,
            Name = "The Last of Us Part II",
            Description = "A gripping and emotional narrative-driven experience set in a post-apocalyptic world.",
            OriginalPrice = 59.99m,
            Discount = 0m,
            FinalPrice = 59.99m,
            Company = "Naughty Dog",
            TrailerUrl = "https://youtu.be/vhII1qlcZ4E?si=rVV7pNU9V7IwBc3t",
            ReleaseDate = new DateTime(2020, 6, 19),
            CategoryId = actionAdventureCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000018"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785144/The_Last_of_Us_Part_II_zifqwd.jpg",
            ProductId = product18Id
        });

        // Product 19: Doom Eternal
        var product19Id = Guid.Parse("A0000000-0000-0000-0000-000000000019");
        products.Add(new Product
        {
            Id = product19Id,
            Name = "Doom Eternal",
            Description = "A high-speed, brutal shooter where you battle demons across multiple dimensions.",
            OriginalPrice = 39.99m,
            Discount = 0m,
            FinalPrice = 39.99m,
            Company = "id Software",
            TrailerUrl = "https://youtu.be/_UuktemkCFI?si=vpM4t0KZtLmComDO",
            ReleaseDate = new DateTime(2020, 3, 20),
            CategoryId = fpsCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000019"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785140/Doom_Eternal_cifdng.jpg",
            ProductId = product19Id
        });

        // Product 20: Monster Hunter: World
        var product20Id = Guid.Parse("A0000000-0000-0000-0000-000000000020");
        products.Add(new Product
        {
            Id = product20Id,
            Name = "Monster Hunter: World",
            Description = "A co-op action RPG where you hunt massive monsters and craft powerful gear.",
            OriginalPrice = 29.99m,
            Discount = 0m,
            FinalPrice = 29.99m,
            Company = "Capcom",
            TrailerUrl = "https://youtu.be/Ro6r15wzp2o?si=3qsaSwk1w21OEmmz",
            ReleaseDate = new DateTime(2018, 1, 26),
            CategoryId = actionRpgCategoryId
        });
        allPhotos.Add(new Photo
        {
            Id = Guid.Parse("B0000000-0000-0000-0000-000000000020"),
            Url = "https://res.cloudinary.com/dtcyvj8q6/image/upload/v1748785140/Monster_Hunter_World_acr9c5.jpg",
            ProductId = product20Id
        });

        return (products, categories, allPhotos);
    }
}