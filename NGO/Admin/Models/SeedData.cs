using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Admin.Models
{
    public static class SeedData
    {
        public static void SeedDataNgo(IApplicationBuilder app)
        {
            StoreDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Ngos.Any())
            {
                context.Ngos.AddRange(
                    new Ngo
                    {
                        Name = "Oxfam",
                        ImageNgo = "event-1.jpg",
                        Description = "Oxfam in Vietnam is part of a global network of Oxfam affiliates and development projects working in more than 90 countries. With our partners, allies and with local communities, we help people to claim rights for themselves.",

                    },
                    new Ngo
                    {
                        Name = "Mudita Foundation",
                        ImageNgo = "event-2.jpg",
                        Description = "We invite you to be part of the Mudita Family. Your donation means the world to us, no matter how big and small and donating below is fast and secure. Support us and feel the Mudita within!",

                    },
                    new Ngo
                    {
                        Name = "Topica Foundation",
                        ImageNgo = "event-3.jpg",
                        Description = "We work to improve living conditions of underpriviledged and orphaned children in Myanmar. In order to achieve that we need your support. Help us today",

                    },
                    new Ngo
                    {
                        Name = "CARE International",
                        ImageNgo = "event-4.jpg",
                        Description = "We serve some of Vietnam’s most vulnerable groups in remote mountainous and urban areas to help them benefit from development, overcome poverty, and achieve equal rights and voice. At the same times, we provide humanitarian and emergency assistance in times of natural disasters." +
                        "We put women in the center because we know that we cannot overcome poverty until all people have equal rights and opportunities.",

                    },
                    new Ngo
                    {
                        Name = "UNICEF",
                        ImageNgo = "event-5.jpg",
                        Description = "UNICEF is the global leader promoting and protecting children’s rights in 190 countries, including Viet Nam.",

                    },
                    new Ngo
                    {
                        Name = "World Wide Fund For Nature",
                        ImageNgo = "event-6.jpg",
                        Description = "Here at WWF, an independent conservation organization active in nearly 100 countries, we are working to sustain the natural world for the benefit of people and wildlife.",

                    },
                    new Ngo
                    {
                        Name = "OxfamA",
                        ImageNgo = "event-1.jpg",
                        Description = "Oxfam in Vietnam is part of a global network of Oxfam affiliates and development projects working in more than 90 countries. With our partners, allies and with local communities, we help people to claim rights for themselves.",

                    },
                    new Ngo
                    {
                        Name = "CARE International",
                        ImageNgo = "event-5.jpg",
                        Description = "Oxfam in Vietnam is part of a global network of Oxfam affiliates and development projects working in more than 90 countries. With our partners, allies and with local communities, we help people to claim rights for themselves.",

                    }
                );
                context.SaveChanges();
            }

            if (!context.Galleries.Any())
            {
                context.Galleries.AddRange(
                    new Gallery
                    {
                        Name = "THE BUSINESS CASE FOR A UN TREATY ON PLASTIC POLLUTION",
                        ImageGallery = "https://wwfasia.awsassets.panda.org/img/screen_shot_2020_10_26_at_7_52_17_am_742251.png"
                    },
                    new Gallery
                    {
                        Name = "ADDRESSING MARINE PLASTIC POLLUTION IN ASIA",
                        ImageGallery = "https://wwfasia.awsassets.panda.org/img/platic_rp_thumb_eng_741518.jpg"
                    },
                    new Gallery
                    {
                        Name = "Dreaming of a more beautiful tomorrow",
                        ImageGallery = "https://www.unicef.org/vietnam/sites/unicef.org.vietnam/files/styles/large/public/YD_vietnam_unicef-3.jpg?itok=vdJgD-50"
                    },
                    new Gallery
                    {
                        Name = "Safety first when children return to school",
                        ImageGallery = "https://www.unicef.org/vietnam/sites/unicef.org.vietnam/files/styles/hero_desktop/public/C55A2693.JPG?itok=XyHLdoqu"
                    },
                    new Gallery
                    {
                        Name = "Happy children's smiles to school",
                        ImageGallery = "https://live.staticflickr.com/3758/10796269424_c9cca6ec90_c.jpg"
                    },
                    new Gallery
                    {
                        Name = "Going to school is fun",
                        ImageGallery = "https://live.staticflickr.com/7346/10796160336_bdfcc7d5ee_c.jpg"
                    },
                    new Gallery
                    {
                        Name = "Scale, Design, and Follow Through: Lessons on moving from a development project to a business in Vietnam’s AloWeather Project",
                        ImageGallery = "https://www.care.org.vn/wp-content/uploads/2020/12/20-1080x720.jpg"
                    },
                    new Gallery
                    {
                        Name = "Các con Làng trẻ em SOS tham gia Chiến dịch “Tôi chọn hành tinh xanh”",
                        ImageGallery = "https://sosvietnam.org/getmedia/583440e2-9640-4eea-8ffe-1a2fa246859e/Toi-chon-hanh-tinh-xanh-6.jpg?width=425"
                    }
                );
            }


                


            if (!context.Programmes.Any())
            {
                context.Programmes.AddRange(
                    new Programme
                    {
                        Name = "Help us to Provide Food to the Hungry",
                        Description = "Majority of the underprivileged patients admitted in Government hospitals are those who come from nearby states are often poor, in several cases family members decide to stay hungry to save money.",
                        ImagesProgram = "cause-1.jpg"
                    },

                    new Programme
                    {
                        Name = "Donate Hygiene and Dignity Kit for Women",
                        Description = "We at Sunflower Foundation have witnessed these struggles homeless women go through with close quarters. While efforts are being taken to provide safe shelters to this section, we cannot shy away from our responsibilities .",
                        ImagesProgram = "cause-2.jpg"
                    },

                    new Programme
                    {
                        Name = "Donate Educational Kit for Children",
                        Description = "We do get a lot of support for children around children’s day. We feel every day is a children’s day. It’s time we who are educated, engage with homeless children and support their education, to ensure a bright and promising future.",
                        ImagesProgram = "cause-3.jpg"
                    },

                    new Programme
                    {
                        Name = "Donate A Blanket. Save A Life",
                        Description = "Every winter, Sunflower Foundation runs a Blanket Donation Campaign, where we provide high quality warm blankets along with dry ration and dignity kits to the underprivileged living in the open on the streets. We try our best to reach out to people.",
                        ImagesProgram = "cause-4.jpg"
                    },

                    new Programme
                    {
                        Name = "Donate food on Death Anniversary of Loved Ones",
                        Description = "Sunflower Foundation will help you to conduct food donation drives on the death anniversary of your near and dear ones. Round the year, we conduct thousands of food donation drives on death anniversaries as per request of our donors.",
                        ImagesProgram = "cause-5.jpg"
                    },

                    new Programme
                    {
                        Name = "Donate Your Old Clothes",
                        Description = "Our Clothes donation drive is exclusively meant for the children and adults in the hospitals, children living near railway tracks, under flyovers, children of daily wagers at construction sites, under- privileged children in Govt. ",
                        ImagesProgram = "cause-6.jpg"
                    },
                    new Programme
                    {
                        Name = "Help the homeless patients awaiting treatment",
                        Description = "Everyday thousands of poor patients come to Delhi for medical treatment. Apart from the medical treatment they face an everyday struggle for food, water and lodging. Majority of these patients remain in critical condition as their healthcare.",
                        ImagesProgram = "cause-1.jpg"
                    },
                    new Programme
                    {
                        Name = "Emergency response and disaster relife",
                        Description = "Our team along with volunteers and doctors are always first to respond to natural or manmade disasters, with principal response efforts focused on food, shelter, water, health and sanitation. ",
                        ImagesProgram = "cause-3.jpg"
                    }
                );
                context.SaveChanges();
            }

            if (!context.AboutUs.Any())
            {
                context.AboutUs.AddRange(
                    new AboutUs
                    {
                        Name = "Welcome to Sunflower Since 2020",
                        ImageAbout = "bg_3.jpg",
                        Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. On her way she met a copy. The copy warned the Little Blind Text, that where it came from it would have been rewritten a thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return to its own, safe country. But nothing the copy said could convince her and so it didn’t take long until a few insidious Copy Writers ambushed her, made her drunk with Longe and Parole and dragged her into their agency, where they abused her for their."
                    }

                );
                context.SaveChanges();
            }

            if (!context.Donates.Any())
            {
                context.Donates.AddRange(
                    new Donate
                    {
                        ProgrammeId = 1,
                        Price = 50000,
                        DateDonate = new DateTime(2020, 10, 05),
                        Description = "support child to go to school"
                    },
                    new Donate
                    {
                        ProgrammeId = 2,
                        Price = 100000,
                        DateDonate = new DateTime(2020, 06, 12),
                        Description = "afforestation and nature conservation"
                    },
                    new Donate
                    {
                        ProgrammeId = 3,
                        Price = 2000000,
                        DateDonate = new DateTime(2020, 07, 03),
                        Description = "food and water support"
                    }

                );
                context.SaveChanges();
            }
            if (!context.Articles.Any())
            {
                context.Articles.AddRange(
                        new Article
                        {
                            ProgrammeId = 1,
                            Name = "Donate Your Old Clothes",
                            Description = "Our Clothes donation drive is exclusively meant for the children and adults in the hospitals, children living near railway tracks, under flyovers, children of daily wagers at construction sites, under- privileged children in Govt.",
                            ImagesNew = "image_1.jpg"
                        },
                         new Article
                         {
                             ProgrammeId = 1,
                             Name = "Donate food on Death Anniversary of Loved Ones",
                             Description = "Sunflower Foundation will help you to conduct food donation drives on the death anniversary of your near and dear ones. Round the year, we conduct thousands of food donation drives on death anniversaries as per request of our donors..",
                             ImagesNew = "image_2.jpg"
                         },
                          new Article
                          {
                              ProgrammeId = 1,
                              Name = "Donate Hygiene and Dignity Kit for Women",
                              Description = "We at Sunflower Foundation have witnessed these struggles homeless women go through with close quarters. While efforts are being taken to provide safe shelters to this section, we cannot shy away from our responsibilities .",
                              ImagesNew = "image_3.jpg"
                          },
                           new Article
                           {
                               ProgrammeId = 1,
                               Name = "Donate Educational Kit for Children",
                               Description = "We do get a lot of support for children around children’s day. We feel every day is a children’s day. It’s time we who are educated, engage with homeless children and support their education.",
                               ImagesNew = "image_4.jpg"
                           },
                            new Article
                            {
                                ProgrammeId = 1,
                                Name = "Celebrate New Year 2021 by donating warm blankets for poor homeless",
                                Description = "New Year’s Resolution 2021 : Celebrate New Year 2021 by helping NGO Sunflower Foundation. Donate blanket for poor homeless and children.",
                                ImagesNew = "image_5.jpg"
                            },
                             new Article
                             {
                                 ProgrammeId = 1,
                                 Name = "Help us to feed poor patients and their families outside hospitals",
                                 Description = "Majority of the underprivileged patients admitted in Government hospitals are those who come from nearby states are often poor, in several cases family members decide to stay hungry to save money.",
                                 ImagesNew = "image_6.jpg"
                             },
                              new Article
                              {
                                  ProgrammeId = 1,
                                  Name = "Help us to Provide Food to the Hungry",
                                  Description = "Majority of the underprivileged patients admitted in Government hospitals are those who come from nearby states are often poor, in several cases family members decide to stay hungry to save money.",
                                  ImagesNew = "image_1.jpg"
                              }
                    );
                context.SaveChanges();
            }
        }
    }
}
