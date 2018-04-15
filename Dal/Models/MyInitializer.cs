using System.Data.Entity;
using System;
using System.Collections.Generic;

namespace Dal
{
    internal class MyInitializer<T> : DropCreateDatabaseAlways<ModelBeauty>
    //CreateDatabaseIfNotExists
    //DropCreateDatabaseAlways
    {
        protected override void Seed(ModelBeauty context)
        {
            WorkPosition admin = new WorkPosition()
            {
                Name = "Admin",
                Staff = new List<Staff>()
            };
            WorkPosition employee = new WorkPosition()
            {
                Name = "Employee",
                Staff = new List<Staff>()
            };
            //context.WorkPositions.AddRange(new List<WorkPosition> { admin, employee });
           // context.SaveChanges();

            List<Staff> listStaff = new List<Staff>();
            Staff staff = new Staff()
            {
                Login = "1",
                Password = "1",
                WorkPosition = admin
            };
            listStaff.Add(staff);
            staff = new Staff()
            {
                Login = "2",
                Password = "2",
                WorkPosition = employee
            };
            //context.WorkPositions.AddRange(new List<WorkPosition> { admin, employee });
            listStaff.Add(staff);
            context.Staffs.AddRange(listStaff);
            context.SaveChanges();

            List<Shampoo> listProductsShampoo = new List<Shampoo>();
            Shampoo productShampoo = new Shampoo()//shampoo
            {
                Name = "Keratin Shampoo",
                Brand = "Estel Professional",
                Price = 195,
                Volume = 250,
                QuantityBottles = 1,
                QuantityGeneralVolume = 250,
                Service = new List<Service>()

            };
            listProductsShampoo.Add(productShampoo);
            productShampoo = new Shampoo()//shampoo
            {
                Name = "Volume Shampoo for Oily Hair",
                Brand = "Estel Professional",
                Price = 195,
                Volume = 250,
                QuantityBottles = 1,
                QuantityGeneralVolume = 250,
                Service = new List<Service>()

            };
            listProductsShampoo.Add(productShampoo);
            context.Materials.AddRange(listProductsShampoo);

            List<HairColor> listProductsColor = new List<HairColor>();
            HairColor productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Red",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);

            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Chestnut",
                Description = "for gray hair",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Dark chestnut",
                Description = "for gray hair",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Light brown",
                Description = "for gray hair",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Golden Brown",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Ash Blonde",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);
            productColor = new HairColor()
            {
                Name = "De Luxe",
                Brand = "Estel Professional",
                Price = 139,
                Volume = 60,
                QuantityBottles = 1,
                Color = "Honey Blondy",
                QuantityGeneralVolume = 60,
                Service = new List<Service>()
            };
            listProductsColor.Add(productColor);
            context.Materials.AddRange(listProductsColor);

            List<Balsam> listProductsBalsam = new List<Balsam>();
            Balsam productBalsam = new Balsam()
            {
                Name = "Prima Blonde Balm",
                Brand = "Estel Professional",
                Price = 825,
                Volume = 1000,
                QuantityBottles = 1,
                QuantityGeneralVolume = 1000,
                Service = new List<Service>()

            };
            listProductsBalsam.Add(productBalsam);
            productBalsam = new Balsam()
            {
                Name = "Otium Miracle",
                Brand = "Estel Professional",
                Price = 135,
                Volume = 200,
                QuantityBottles = 1,
                QuantityGeneralVolume = 200,
                Service = new List<Service>()

            };
            listProductsBalsam.Add(productBalsam);
            productBalsam = new Balsam()
            {
                Name = "Otium iNeo-Crystal",
                Brand = "Estel Professional",
                Price = 140,
                Volume = 250,
                QuantityBottles = 1,
                QuantityGeneralVolume = 250,
                Service = new List<Service>()

            };
            listProductsBalsam.Add(productBalsam);
            context.Materials.AddRange(listProductsBalsam);

            List<Laque> listProductsLaque = new List<Laque>();
            Laque productLaque = new Laque()

            {
                Name = "Airex",
                Brand = "Estel Professional",
                Price = 227,
                Volume = 400,
                QuantityBottles = 1,
                QuantityGeneralVolume = 400,
                Service = new List<Service>()

            };
            listProductsLaque.Add(productLaque);
            context.Materials.AddRange(listProductsLaque);

            List<Foundation> listProductsFountation = new List<Foundation>();
            Foundation productFoundation = new Foundation()
            {
                Name = "24h Infaillible",
                Brand = "L'Oreal Paris",
                Price = 245,
                Volume = 35,
                QuantityBottles = 1,
                Color = "creamy beige",
                QuantityGeneralVolume = 35,
                Service = new List<Service>()

            };
            listProductsFountation.Add(productFoundation);
            productFoundation = new Foundation()//foundation
            {
                Name = "Alliance Perfect",
                Brand = "L'Oreal Paris",
                Price = 190,
                Volume = 30,
                QuantityBottles = 1,
                Color = "golden natural",
                QuantityGeneralVolume = 30,
                Service = new List<Service>()

            };
            listProductsFountation.Add(productFoundation);
            context.Materials.AddRange(listProductsFountation);

            List<Shadows> listProductsShadow = new List<Shadows>();
            Shadows productsShadow = new Shadows()

            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "grisante",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>()

            };
            listProductsShadow.Add(productsShadow);
            productsShadow = new Shadows()//shadow
            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "extra-vertie",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>()

            };
            listProductsShadow.Add(productsShadow);
            productsShadow = new Shadows()//shadow
            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "lunaire",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>()

            };
            listProductsShadow.Add(productsShadow);
            productsShadow = new Shadows()//shadow
            {
                Name = "Color Riche Mono",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 4.7,
                QuantityBottles = 1,
                Color = "emauvante",
                QuantityGeneralVolume = 4.7,
                Service = new List<Service>()

            };
            listProductsShadow.Add(productsShadow);
            context.Materials.AddRange(listProductsShadow);

            List<Lipstick> listProductLipstick = new List<Lipstick>();
            Lipstick productLipstick = new Lipstick()

            {
                Name = "Intense Lipstick",
                Brand = "L'Oreal Paris",
                Price = 261,
                Volume = 4.2,
                QuantityBottles = 1,
                Color = "classic passion",
                QuantityGeneralVolume = 4.2,
                Service = new List<Service>()

            };
            listProductLipstick.Add(productLipstick);
            productLipstick = new Lipstick()//lipstick
            {
                Name = "Intense Lipstick",
                Brand = "L'Oreal Paris",
                Price = 261,
                Volume = 4.2,
                QuantityBottles = 1,
                Color = "magnetic coral",
                QuantityGeneralVolume = 4.2,
                Service = new List<Service>()

            };
            listProductLipstick.Add(productLipstick);
            context.Materials.AddRange(listProductLipstick);


            List<Powder> listProductPowder = new List<Powder>();
            Powder productPowder = new Powder()

            {
                Name = "Infallible Powder",
                Brand = "L'Oreal Paris",
                Price = 280,
                Volume = 9,
                QuantityBottles = 1,
                Color = "warm vanilla",
                QuantityGeneralVolume = 9,
                Service = new List<Service>()

            };
            listProductPowder.Add(productPowder);
            productPowder = new Powder()//powder
            {
                Name = "Infallible Powder",
                Brand = "L'Oreal Paris",
                Price = 280,
                Volume = 9,
                QuantityBottles = 1,
                Color = "sand beige",
                QuantityGeneralVolume = 9,
                Service = new List<Service>()
            };
            listProductPowder.Add(productPowder);
            productPowder = new Powder()//powder
            {
                Name = "Infallible Powder",
                Brand = "L'Oreal Paris",
                Price = 280,
                Volume = 9,
                QuantityBottles = 1,
                Color = "warm sand",
                QuantityGeneralVolume = 9,
                Service = new List<Service>()
            };
            listProductPowder.Add(productPowder);
            context.Materials.AddRange(listProductPowder);

            List<Mascara> listProductMascara = new List<Mascara>();
            Mascara productMascara = new Mascara()

            {
                Name = "Volumissime Mascara",
                Brand = "L'Oreal Paris",
                Price = 183,
                Volume = 7.5,
                QuantityBottles = 1,
                QuantityGeneralVolume = 7.5,
                Service = new List<Service>()
            };
            listProductMascara.Add(productMascara);
            context.Materials.AddRange(listProductMascara);

            List<NailBase> listProductsBase = new List<NailBase>();
            NailBase productBase = new NailBase()

            {
                Name = "Professional Rubber Base",
                Brand = "Kodi ",
                Price = 185,
                Volume = 14,
                QuantityBottles = 1,
                QuantityGeneralVolume = 14,
                Service = new List<Service>()

            };
            listProductsBase.Add(productBase);
            context.Materials.AddRange(listProductsBase);

            List<NailTop> listProductTop = new List<NailTop>();
            NailTop productTop = new NailTop()

            {
                Name = "Professional Rubber Top",
                Brand = "Kodi ",
                Price = 185,
                Volume = 14,
                QuantityBottles = 1,
                QuantityGeneralVolume = 14,
                Service = new List<Service>()
            };
            listProductTop.Add(productTop);
            context.Materials.AddRange(listProductTop);

            List<NailPolish> listProductPolish = new List<NailPolish>();
            NailPolish productPolish = new NailPolish()

            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "wild nude",
                QuantityGeneralVolume = 12,
                Service = new List<Service>()
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()//gelPolish
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "marshmallow",
                QuantityGeneralVolume = 12,
                Service = new List<Service>()
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()//gelPolish
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "pink diamond",
                QuantityGeneralVolume = 12,
                Service = new List<Service>()
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()//gelPolish
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "chubby cheeks",
                QuantityGeneralVolume = 12,
                Service = new List<Service>()
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()//gelPolish
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "grenatium",
                QuantityGeneralVolume = 12,
                Service = new List<Service>()
            };
            listProductPolish.Add(productPolish);
            productPolish = new NailPolish()//gelPolish
            {
                Name = "Gel Polish ",
                Brand = "Kodi ",
                Price = 249,
                Volume = 12,
                QuantityBottles = 1,
                Color = "amethyst noir",
                QuantityGeneralVolume = 12,
                Service = new List<Service>()
            };
            listProductPolish.Add(productPolish);

            context.Materials.AddRange(listProductPolish);

            context.SaveChanges();
         
            Service hairCut = new Service()
            {
                Name = "HairCut",
                Price = 80,
                Materials = new List<Material> { productShampoo, productBalsam, productLaque }
            };
            Service hairColor = new Service()
            {
                Name = "HairColoring",
                Price = 400,
                Materials = new List<Material> { productShampoo, productBalsam, productLaque, productColor }
            };
            Service makeUp = new Service()
            {
                Name = "MakeUp",
                Price = 300,
                Materials = new List<Material> { productFoundation, productLipstick, productPowder, productMascara, productsShadow }
            };
            Service manicure = new Service()
            {
                Name = "Manicure",
                Price = 170,
                Materials = new List<Material> { productTop, productPolish, productBase }
            };
            context.Services.AddRange(new List<Service> { hairCut, hairColor, makeUp, manicure });
            context.SaveChanges();
        }


    }
}