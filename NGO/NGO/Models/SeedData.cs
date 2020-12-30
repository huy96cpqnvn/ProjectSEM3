using System;
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
                        Name = "WHO WE ARE",
                        ImageAbout = "https://www.care.org.vn/wp-content/uploads/2019/11/cover-event-final-final-eng.png",
                        Description = "We serve some of Vietnam’s most vulnerable groups in remote mountainous and urban areas to help them benefit from development, " +
                        "overcome poverty, and achieve equal rights and voice. At the same times, we provide humanitarian and emergency assistance in times of natural disasters." +
                        "We put women in the center because we know that we cannot overcome poverty until all people have equal rights and opportunities."
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
                        ProgrameId = 1,
                        Name = "All apart, all together: a glimpse into the festive season around the world",
                        ImagesNew = "https://oi-files-d8-prod.s3.eu-west-2.amazonaws.com/s3fs-public/styles/hero_image_extra_large/public/2020-12/Honduras_hurricane_family.jpg?h=bf87a64c&itok=2EH-81lX",
                        Description = "This year David Argueta and his family will not celebrate Christmas in their house. The hurricanes Eta and Iota wreaked havoc on all of Central America, and destroyed a big part of their property. Despite being left with nothing, the tiny bit of hope they have keeps them optimistic. Next year they hope to rebuild their house and continue living there. Photo: Seth Berry/Oxfam" +
                        "This year's festive period is like no other. The Covid-19 pandemic and its economic fallout have impacted all of us, some far more than others. Millions are bracing for this festive season with little or no food, as their income got cut. Some have lost their loved ones to the disease." +
                        "Here are some stories showing how vulnerable people around the world are celebrating this year. The holidays have united them in their hope for a better future, despite all the hardship.",
                    },
                    new Article
                    {
                        ProgrameId = 2,
                        Name = "Multidimensional Inequality in Vietnam",
                        ImagesNew = "https://oi-files-cng-prod.s3.amazonaws.com/vietnam.oxfam.org/s3fs-public/styles/full-width-670x335-2_1/public/103898.jpg?itok=68lzkcMA",
                        Description = "Vietnam has achieved great economic development over the past 30 years. However, there is growing concern over increasing inequalities in other aspects of life, in particular opportunities and voice for certain population subgroups. Meanwhile, there is still a sizeable and significant lacuna in multidimensional analysis to provide a comprehensive and indepth view of inequality." +
                        "This study is a first attempt to examine multidimensional inequality in those key domains of inequality in the country: life and health, education and learning, and participation, influence, and voice." +
                        "The research findings point at large gaps between subpopulation groups across spatial, socio-economic, and ethnic axes of inequalities in their capability to enjoy the right to a proper, quality education and to experience a life free of illness and access to quality healthcare facilities. People belonging to ethnic minorities (EM), women, and inhabitants from rural provinces are more affected by inequalities in health and education than the Kinh, men, and higher-income households living in predominantly urban areas. Furthermore, inequality in the capability to participate, raise one’s voice, and influence public matters is extremely acute between men and women and the poorest households and with a lower level of education, compared to the richest, urban, highly educated households."
                    },
                    new Article
                    {
                        Name = "THE CAMPAIGN “SPREADING LOVE - EDUCATION WITH LOVE”",
                        ImagesNew = "https://vietnam.savethechildren.net/sites/vietnam.savethechildren.net/files/field/image/%C4%90%E1%BA%A1i%20di%E1%BB%87n%20tr%E1%BA%BB%20em%20v%C3%A0%20c%C3%A1c%20%C4%91%E1%BA%A1i%20bi%E1%BB%83u%20tham%20d%E1%BB%B1%20H%E1%BB%99i%20th%E1%BA%A3o.jpg",
                        Description = "In order to raise awareness on the elimination of physical and humiliating punishments against children, Save the Children, together with Management and Sustainable Development Institute (MSD) collaborate with Child Rights Governance Network and Department of Children Affairs, and many other government partners to organize the campaign “Spreading Love - Education with Love”." +
                        "The campaign was held in October-November 2020 with a series of activities including the 21-day challenge 'My home story - Education with Love', outdoor communication events, social media communication, and trainings for children and policy dialogue “Voices of children and stakeholders in promoting children's rights and ending physical and humiliating punishments against children”. We have managed to gain 200,000 reaches on social media. The Festival “Spreading Love” was held in Hanoi and Ho Chi Minh City with the participation of nearly 1,000 children, caregivers and representatives of related agencies. It also spread and positively inspired the community with the participation and accompany of some famous artists such as Meritorious artist Xuan Bac, Singer Chi Thien, Rapper Wowy ..." +
                        "More than 60 children participated in the training on children's participation in the prevention of physical and humiliating punishments against children. They analyzed the situation and causes of punishments against children and proposed solutions to promote children's rights. They presented children's recommendations at the policy dialogue with the messages: “We love parents with heart, parents please don't love me with corporal punishment or scold!”. They expressed their wishes for their voices to be heard, understood and recognized by the state management agencies, schools, and parents."
                    },
                    new Article
                    {
                        ProgrameId = 1,
                        Name = "SAFE WATER, PROPERTY DAMAGE, AND EDUCATION INTERVENTIONS FOR VULNERABLE COMMUNITIES AFFECTED BY SEVERE FLOODS IN CENTRAL VIETNAM",
                        ImagesNew = "https://vietnam.savethechildren.net/sites/vietnam.savethechildren.net/files/field/image/2.png",
                        Description = "Since the beginning of October, the provinces in the central Vietnam have experienced several tropical storms followed by heavy rains that caused severe widespread flooding and landslides. The most seriously affected provinces are Quang Binh, Quang Tri, Thua Thien Hue and Quang Nam. This series of disasters have damaged houses, schools, and crops." +
                        "“Heavy rains and floods happen every year, but this year is much more severe. Even though we were notified by the authority and could anticipate how bad it could get, but in low-lying areas like where I live, floodwater rushed in too quickly. Floodwater was as high as 1 meter in my house; 1 pig, half of my chicken flock and 70-80 kg of rice were gone. I can only sell that ruined rice as livestock feed now.” – Mr. Minh, living in Trieu Long commune, Quang Tri province, said." +
                        "In supporting the Vietnamese government to lessen the disasters’ effects on these communities, especially children, Save the Children is conducting interventions on safe water, property damage, and education by providing water filters, education kits, household kits and cash support. This immediate support is designed to help the affected children and communities to recover quickly after these devastating floods." +
                        "Please share your well wishes for these families across central Vietnam as they recover from these disasters."
                    },
                    new Article
                    {
                        ProgrameId = 3,
                        Name = "Công ty thời trang VMG hợp tác tài trợ chương trình 'Viết tiếp ước mơ'",
                        ImagesNew = "https://sosvietnam.org/getmedia/809acc3f-d931-49c9-934e-a336ff71b670/1.png?width=1920",
                        Description = "VMG Fashion luôn có những hành động tích cực chia sẻ với cộng đồng với sứ mệnh nỗ lực xây dựng môi trường làm việc chuyên nghiệp, phát triển đội ngũ nhân viên tinh nhuệ, gắn kết và đồng lòng xây dựng doanh nghiệp phát triển bền vững, tập trung toàn lực vào sứ mệnh mang phong cách thời trang lịch lãm và tinh tế đến cuộc sống hàng ngày, đồng hành cùng thành công và hạnh phúc của khách hàng; không ngừng đóng góp giá trị cho thành công của cộng đồng và xã hội." +
                        "Trong thời gian hoạt động, VMG Fashion có các hoạt động thiện nguyện, tài trợ cho các tổ chức phi lợi nhuận dành cho trẻ em cùng các hoạt động thiện nguyện do chính công ty tổ chức. Bên cạnh đó, VMG Fashion cũng tổ chức thăm hỏi, động viên và trao học bổng cho các học sinh nghèo có hoàn cảnh khó khăn vươn lên có thành tích học tập tốt." +
                        "VMG Fashion (Mã tài trợ CCG92) đã trở thành Nhà tài trợ Hoa hồng, cùng đồng hành với Làng trẻ em SOS Việt Nam thực hiện Chương trình “Viết tiếp ước mơ” từ ngày 10/11/2020 đến 10/11/2021 cho các con ở Làng trẻ em SOS TP. Hồ Chí Minh với tổng ngân sách là 100,000,000 VNĐ, cùng với nhiều hoạt động thăm gặp, đồng viên tinh thần cho các con vào các dịp trong năm."
                    },
                    new Article
                    {
                        ProgrameId = 3,
                        Name = "“Việt Nam cần coi bảo tồn đa dạng sinh học là một vấn đề đạo đức”",
                        ImagesNew = "https://wwfasia.awsassets.panda.org/img/1_original_ww2138125_741548.jpg",
                        Description = "“Chúng ta đang đối diện với những thách thức to lớn liên quan đến đa dạng sinh học do chính con người tạo ra. Đã đến lúc chúng ta, bên cạnh việc sử dụng chính sách và pháp luật, thì cần phải coi bảo tồn đa dạng sinh học là một vấn đề đạo đức, trước hết ở cấp lãnh đạo, sau đến mọi người dân” Bộ trưởng Trần Hồng Hà phát biểu trong video trực tuyến tại Hội nghị Thượng đỉnh Liên Hợp Quốc về Đa dạng Sinh học. " +
                        "Hội nghị Liên Hợp Quốc về Đa dạng Sinh học được tổ chức vào ngày hôm nay, 30 tháng 9 năm 2020 ở cấp nguyên thủ quốc gia và chính phủ với chủ đề Hành động Khẩn cấp về Đa dạng Sinh học vì sự Phát triển Bền vững. " +
                        "Hội nghị được tổ chức khi chúng ta tiến gần đến cuối Thập kỷ của Liên Hợp Quốc về Đa dạng Sinh học 2011-2020 với toàn bộ mục tiêu mà 190 nước cùng đặt ra từ 10 năm trước đều không đạt được." +
                        "Trước đó, ngày 28 tháng 9, các nhà lãnh đạo từ nhiều quốc gia cũng tham gia sự kiện của các nhà lãnh đạo và thông qua Cam kết của các Nhà lãnh đạo vì Thiên nhiên. Việt Nam cũng bày tỏ sự quan tâm tới cam kết này. " +
                        "Bản cam kết là một phần của chương trình Nature for Life Hub, và là một hồi đáp trực tiếp đối với Tình trạng Khẩn cấp trên toàn cầu, nêu bật tính cấp thiết của việc giải quyết các cuộc khủng hoảng có sự liên hệ mật thiết với nhau: đa dạng sinh học, khí hậu và y tế."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
