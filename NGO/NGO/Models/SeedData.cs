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
                        ImageNgo = "/img/ImageNgo/oxfam.jpg",
                        Description = "Oxfam in Vietnam is part of a global network of Oxfam affiliates and " +
                        "development projects working in more than 90 countries." +
                        " With our partners, allies and with local communities, " +
                        "we help people to claim rights for themselves.",

                    },
                    new Ngo
                    {
                        Name = "Save the children",
                        ImageNgo = "/img/ImageNgo/savethechildren.jpg",
                        Description = "WE CAN END CHILD HUNGER.",

                    },
                    new Ngo
                    {
                        Name = "Làng trẻ em SOS",
                        ImageNgo = "SOS_VN.jpg",
                        Description = "Làng trẻ em SOS là nơi chăm sóc, nuôi dưỡng, hỗ trợ trẻ em mồ côi, " +
                        "trẻ em bị bỏ rơi và trẻ em có hoàn cảnh khó khăn.",

                    },
                    new Ngo
                    {
                        Name = "CARE International",
                        ImageNgo = "/img/ImageNgo/care.jpg",
                        Description = "We serve some of Vietnam’s most vulnerable groups in remote mountainous and " +
                        "urban areas to help them benefit from development, overcome poverty, and achieve equal rights and voice." +
                        " At the same times, we provide humanitarian and emergency assistance in times of natural disasters." +
                        "We put women in the center because we know that we cannot overcome poverty until all people have equal rights and opportunities.",

                    },
                    new Ngo
                    {
                        Name = "UNICEF",
                        ImageNgo = "/img/ImageNgo/unicef.jpg",
                        Description = "UNICEF is the global leader promoting and protecting children’s rights in 190 countries, including Viet Nam.",

                    },
                    new Ngo
                    {
                        Name = "World Wide Fund For Nature",
                        ImageNgo = "/img/ImageNgo/WWF.jpg",
                        Description = "Here at WWF, an independent conservation organization active in nearly 100 countries, " +
                        "we are working to sustain the natural world for the benefit of people and wildlife.",

                    }
                );
                context.SaveChanges();
            }

            if (!context.News.Any())
            {
                context.News.AddRange(
                    new New
                    {
                        Name = "All apart, all together: a glimpse into the festive season around the world",
                        ImagesNew = "/img/ImageNew/Honduras_hurricane_family.jpg",
                        Description = "This year David Argueta and his family will not celebrate Christmas in their house. " +
                        "The hurricanes Eta and Iota wreaked havoc on all of Central America, and destroyed a big part of their property. " +
                        "Despite being left with nothing, the tiny bit of hope they have keeps them optimistic. " +
                        "Next year they hope to rebuild their house and continue living there. Photo: Seth Berry/Oxfam" +
                        "This year's festive period is like no other. The Covid-19 pandemic and its economic fallout have impacted all of us, " +
                        "some far more than others. Millions are bracing for this festive season with little or no food, as their income got cut. " +
                        "Some have lost their loved ones to the disease." +
                        "Here are some stories showing how vulnerable people around the world are celebrating this year. " +
                        "The holidays have united them in their hope for a better future, despite all the hardship.",
                    },
                    new New
                    {
                        Name = "Multidimensional Inequality in Vietnam",
                        ImagesNew = "/img/ImageNew/poor_family.jpg",
                        Description = "Vietnam has achieved great economic development over the past 30 years. " +
                        "However, there is growing concern over increasing inequalities in other aspects of life, " +
                        "in particular opportunities and voice for certain population subgroups. " +
                        "Meanwhile, there is still a sizeable and significant lacuna in multidimensional analysis" +
                        " to provide a comprehensive and indepth view of inequality." +
                        "This study is a first attempt to examine multidimensional inequality in those key domains of inequality " +
                        "in the country: life and health, education and learning, and participation, influence, and voice." +
                        "The research findings point at large gaps between subpopulation groups across spatial, socio-economic, " +
                        "and ethnic axes of inequalities in their capability to enjoy the right to a proper, quality education and " +
                        "to experience a life free of illness and access to quality healthcare facilities. People belonging to ethnic minorities (EM), women, and inhabitants from rural provinces are more affected by inequalities in health and education than the Kinh, men, and higher-income households living in predominantly urban areas. Furthermore, inequality in the capability to participate, raise one’s voice, and influence public matters is extremely acute between men and women and the poorest households and with a lower level of education, compared to the richest, urban, highly educated households."
                    },
                    new New
                    {
                        Name = "THE CAMPAIGN “SPREADING LOVE - EDUCATION WITH LOVE”",
                        ImagesNew = "/img/ImageNew/campaign_for_children_in_SOS.jpg",
                        Description = "In order to raise awareness on the elimination of physical and" +
                        " humiliating punishments against children, Save the Children, together with " +
                        "Management and Sustainable Development Institute (MSD) collaborate with " +
                        "Child Rights Governance Network and Department of Children Affairs, and many other government partners" +
                        " to organize the campaign “Spreading Love - Education with Love”." +
                        "The campaign was held in October-November 2020 with a series of activities including " +
                        "the 21-day challenge 'My home story - Education with Love', outdoor communication events, " +
                        "social media communication, and trainings for children and policy dialogue " +
                        "“Voices of children and stakeholders in promoting children's rights and ending physical and humiliating punishments against children”. " +
                        "We have managed to gain 200,000 reaches on social media. The Festival “Spreading Love” was" +
                        " held in Hanoi and Ho Chi Minh City with the participation of nearly 1,000 children, caregivers and " +
                        "representatives of related agencies. It also spread and positively inspired the community with " +
                        "the participation and accompany of some famous artists such as Meritorious artist Xuan Bac, " +
                        "Singer Chi Thien, Rapper Wowy ..." +
                        "More than 60 children participated in the training on children's participation" +
                        " in the prevention of physical and humiliating punishments against children. " +
                        "They analyzed the situation and causes of punishments against children and proposed solutions" +
                        " to promote children's rights. They presented children's recommendations at the policy dialogue " +
                        "with the messages: “We love parents with heart, parents please don't love me with corporal punishment or scold!”. " +
                        "They expressed their wishes for their voices to be heard, understood and recognized by the state management agencies, schools, and parents."
                    },
                    new New
                    {
                        Name = "SAFE WATER, PROPERTY DAMAGE, AND EDUCATION INTERVENTIONS FOR VULNERABLE COMMUNITIES AFFECTED BY SEVERE FLOODS IN CENTRAL VIETNAM",
                        ImagesNew = "/img/ImageNew/safe_water_and_food.png",
                        Description = "Since the beginning of October, the provinces in the central Vietnam have " +
                        "experienced several tropical storms followed by heavy rains that caused severe widespread flooding and landslides. " +
                        "The most seriously affected provinces are Quang Binh, Quang Tri, Thua Thien Hue and Quang Nam. " +
                        "This series of disasters have damaged houses, schools, and crops." +
                        "“Heavy rains and floods happen every year, but this year is much more severe. " +
                        "Even though we were notified by the authority and could anticipate how bad it could get, " +
                        "but in low-lying areas like where I live, floodwater rushed in too quickly. " +
                        "Floodwater was as high as 1 meter in my house; 1 pig, half of my chicken flock and 70-80 kg of rice were gone. " +
                        "I can only sell that ruined rice as livestock feed now.” – Mr. Minh, living in Trieu Long commune, Quang Tri province, said." +
                        "In supporting the Vietnamese government to lessen the disasters’ effects on these communities, especially children, " +
                        "Save the Children is conducting interventions on safe water, property damage, and education by providing water filters, " +
                        "education kits, household kits and cash support. This immediate support is designed to help the affected children and " +
                        "communities to recover quickly after these devastating floods." +
                        "Please share your well wishes for these families across central Vietnam as they recover from these disasters."
                    },
                    new New
                    {
                        Name = "Công ty thời trang VMG hợp tác tài trợ chương trình 'Viết tiếp ước mơ'",
                        ImagesNew = "img/ImageNew/Wings_to_Dream.png",
                        Description = "VMG Fashion luôn có những hành động tích cực chia sẻ với cộng đồng với sứ mệnh nỗ lực xây dựng môi trường làm việc chuyên nghiệp, " +
                        "phát triển đội ngũ nhân viên tinh nhuệ, gắn kết và đồng lòng xây dựng doanh nghiệp phát triển bền vững, " +
                        "tập trung toàn lực vào sứ mệnh mang phong cách thời trang lịch lãm và tinh tế đến cuộc sống hàng ngày, " +
                        "đồng hành cùng thành công và hạnh phúc của khách hàng; không ngừng đóng góp giá trị cho thành công của cộng đồng và xã hội." +
                        "Trong thời gian hoạt động, VMG Fashion có các hoạt động thiện nguyện, tài trợ cho các tổ chức phi lợi nhuận " +
                        "dành cho trẻ em cùng các hoạt động thiện nguyện do chính công ty tổ chức. " +
                        "Bên cạnh đó, VMG Fashion cũng tổ chức thăm hỏi, động viên và trao học bổng cho các học sinh nghèo " +
                        "có hoàn cảnh khó khăn vươn lên có thành tích học tập tốt." +
                        "VMG Fashion (Mã tài trợ CCG92) đã trở thành Nhà tài trợ Hoa hồng, cùng đồng hành với " +
                        "Làng trẻ em SOS Việt Nam thực hiện Chương trình “Viết tiếp ước mơ” từ ngày 10/11/2020 đến 10/11/2021 " +
                        "cho các con ở Làng trẻ em SOS TP. Hồ Chí Minh với tổng ngân sách là 100,000,000 VNĐ, cùng với nhiều hoạt động thăm gặp, " +
                        "đồng viên tinh thần cho các con vào các dịp trong năm."
                    },
                    new New
                    {
                        Name = "“Việt Nam cần coi bảo tồn đa dạng sinh học là một vấn đề đạo đức”",
                        ImagesNew = "img/ImageNew/Forest_fires.jpg",
                        Description = "“Chúng ta đang đối diện với những thách thức to lớn liên quan đến đa dạng sinh học do chính con người tạo ra. " +
                        "Đã đến lúc chúng ta, bên cạnh việc sử dụng chính sách và pháp luật, thì cần phải coi bảo tồn đa dạng sinh học là một vấn đề đạo đức, " +
                        "trước hết ở cấp lãnh đạo, sau đến mọi người dân” Bộ trưởng Trần Hồng Hà phát biểu trong video trực tuyến tại Hội nghị Thượng đỉnh Liên Hợp Quốc về Đa dạng Sinh học. " +
                        "Hội nghị Liên Hợp Quốc về Đa dạng Sinh học được tổ chức vào ngày hôm nay, 30 tháng 9 năm 2020 ở cấp nguyên thủ quốc gia và chính phủ với chủ đề Hành động Khẩn cấp về Đa dạng Sinh học vì sự Phát triển Bền vững. " +
                        "Hội nghị được tổ chức khi chúng ta tiến gần đến cuối Thập kỷ của Liên Hợp Quốc về Đa dạng Sinh học 2011-2020 với toàn bộ mục tiêu mà 190 nước cùng đặt ra từ 10 năm trước đều không đạt được." +
                        "Trước đó, ngày 28 tháng 9, các nhà lãnh đạo từ nhiều quốc gia cũng tham gia sự kiện của các nhà lãnh đạo và thông qua Cam kết của các Nhà lãnh đạo vì Thiên nhiên. Việt Nam cũng bày tỏ sự quan tâm tới cam kết này. " +
                        "Bản cam kết là một phần của chương trình Nature for Life Hub, và là một hồi đáp trực tiếp đối với Tình trạng Khẩn cấp trên toàn cầu, nêu bật tính cấp thiết của việc giải quyết các cuộc khủng hoảng có sự liên hệ mật thiết với nhau: đa dạng sinh học, khí hậu và y tế."
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
                        ImageGallery = "img/ImageGallery/plastic_in_sea.png"
                    },
                    new Gallery
                    {
                        Name = "ADDRESSING MARINE PLASTIC POLLUTION IN ASIA",
                        ImageGallery = "img/ImageGallery/plastic_in_sea2.png"
                    },
                    new Gallery
                    {
                        Name = "Dreaming of a more beautiful tomorrow",
                        ImageGallery = "img/ImageGallery/YD_vietnam_unicef.jpg"
                    },
                    new Gallery
                    {
                        Name = "Safety first when children return to school",
                        ImageGallery = "img/ImageGallery/child_unicef.jpg"
                    },
                    new Gallery
                    {
                        Name = "Happy children's smiles to school",
                        ImageGallery = "img/ImageGallery/smile_of_child.jpg"
                    },
                    new Gallery
                    {
                        Name = "Going to school is fun",
                        ImageGallery = "img/ImageGallery/smile_of_child2.jpg"
                    },
                    new Gallery
                    {
                        Name = "Scale, Design, and Follow Through: Lessons on moving from a development project to a business in Vietnam’s AloWeather Project",
                        ImageGallery = "img/ImageGallery/care_women.jpg"
                    },
                    new Gallery
                    {
                        Name = "Các con Làng trẻ em SOS tham gia Chiến dịch “Tôi chọn hành tinh xanh”",
                        ImageGallery = "img/ImageGallery/BlueEarth.jpg"
                    }
                );
                context.SaveChanges();
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
                        ImageAbout = "/img/ImageAbout/weare.png",
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
    }
}
