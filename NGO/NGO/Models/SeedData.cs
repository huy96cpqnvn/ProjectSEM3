﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace NGO.Models
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
                        ImageNgo = "https://media-exp1.licdn.com/dms/image/C560BAQGxggEAfTho3A/company-logo_200_200/0/1551261387275?e=2159024400&v=beta&t=fc7SER96kkBNQAC9GjCEaz0Nrd9VXAuM1h8-Towm4Fc",
                        Description = "Oxfam in Vietnam is part of a global network of Oxfam affiliates and development projects working in more than 90 countries. With our partners, allies and with local communities, we help people to claim rights for themselves.",

                    },
                    new Ngo
                    {
                        Name = "Save the children",
                        ImageNgo = "https://khoamoitruonghue.edu.vn/uploads/News/pic/1342102315.nv.jpg",
                        Description = "WE CAN END CHILD HUNGER.",

                    },
                    new Ngo
                    {
                        Name = "Làng trẻ em SOS",
                        ImageNgo = "https://cdn.canavi.com/files/temp/2019/5/30/20190530083741.jpg",
                        Description = "Làng trẻ em SOS là nơi chăm sóc, nuôi dưỡng, hỗ trợ trẻ em mồ côi, trẻ em bị bỏ rơi và trẻ em có hoàn cảnh khó khăn.",

                    },
                    new Ngo
                    {
                        Name = "CARE International",
                        ImageNgo = "https://thumbor.forbes.com/thumbor/fit-in/416x416/filters%3Aformat%28jpg%29/https%3A%2F%2Fi.forbesimg.com%2Fmedia%2Flists%2Fcompanies%2Fcare-usa_416x416.jpg",
                        Description = "We serve some of Vietnam’s most vulnerable groups in remote mountainous and urban areas to help them benefit from development, overcome poverty, and achieve equal rights and voice. At the same times, we provide humanitarian and emergency assistance in times of natural disasters." +
                        "We put women in the center because we know that we cannot overcome poverty until all people have equal rights and opportunities.",

                    },
                    new Ngo
                    {
                        Name = "UNICEF",
                        ImageNgo = "https://www.unicef.org/vietnam/themes/custom/unicef_base/UNICEF_ForEveryChild_White_Vertical_RGB_ENG.jpg",
                        Description = "UNICEF is the global leader promoting and protecting children’s rights in 190 countries, including Viet Nam.",

                    },
                    new Ngo
                    {
                        Name = "World Wide Fund For Nature",
                        ImageNgo = "data:image/jpeg;base64,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",
                        Description = "Here at WWF, an independent conservation organization active in nearly 100 countries, we are working to sustain the natural world for the benefit of people and wildlife.",

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
                        ImageGallery = "hhttps://sosvietnam.org/getmedia/583440e2-9640-4eea-8ffe-1a2fa246859e/Toi-chon-hanh-tinh-xanh-6.jpg?width=425"
                    }
                );
            }





            if (!context.Programmes.Any())
            {
                context.Programmes.AddRange(
                    new Programme
                    {
                        Name = "Education"
                    },

                    new Programme
                    {
                        Name = "Child Protection"
                    },

                    new Programme
                    {
                        Name = "Health and Nutrition"
                    },

                    new Programme
                    {
                        Name = "Safeguarding the Natural World "
                    },

                    new Programme
                    {
                        Name = "Support for people with disabilities"
                    },

                    new Programme
                    {
                        Name = "Support from overcome poverty, and achieve equal rights and voice"
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
                             Description = "Uday Foundation will help you to conduct food donation drives on the death anniversary of your near and dear ones. Round the year, we conduct thousands of food donation drives on death anniversaries as per request of our donors..",
                             ImagesNew = "image_2.jpg"
                         },
                          new Article
                          {
                              ProgrammeId = 1,
                              Name = "Donate Hygiene and Dignity Kit for Women",
                              Description = "We at Uday Foundation have witnessed these struggles homeless women go through with close quarters. While efforts are being taken to provide safe shelters to this section, we cannot shy away from our responsibilities .",
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
                                Description = "New Year’s Resolution 2021 : Celebrate New Year 2021 by helping NGO Uday Foundation. Donate blanket for poor homeless and children.",
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
