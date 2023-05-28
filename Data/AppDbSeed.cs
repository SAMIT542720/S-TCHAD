using S_TCHAD.Models;
using Microsoft.AspNetCore.Identity;
using static System.Net.WebRequestMethods;
using S_TCHAD.Data.Static;

namespace S_TCHAD.Data
{
    public class AppDbSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScop = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScop.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.IBAYAT_AND_FASATINS.Any())
                {
                    context.IBAYAT_AND_FASATINS.AddRange(new List<IBAYAT_AND_FASATIN>()
                    {
                        new IBAYAT_AND_FASATIN()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348711035_931540521260821_7467829053531234706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=JH3TFfY0jX4AX9Dtyuo&_nc_ht=scontent-los2-1.xx&oh=00_AfAX9yLb-l3Fr2P82XZvYZDBcPMJyNuaGwEneCeUBcIvAQ&oe=6473DAE5",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348597882_811838663849275_6541443067414319706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=6Bbciii_E24AX9Trw_1&_nc_ht=scontent-los2-1.xx&oh=00_AfCVg0u2SRPEPtt4OHKB_g88RJs80FtlrWoWpP-DLqozjw&oe=64731E62",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348565135_284221830608711_150920686655546490_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3anKjHr64ysAX9puY2b&_nc_ht=scontent-los2-1.xx&oh=00_AfCz7Oy_l3NQ7mprOVfQGNb73urXCnyKypeEQV0aUkYgBg&oe=6471F83E",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new IBAYAT_AND_FASATIN()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348440090_281052217606537_154215370613906284_n.jpg?stp=dst-jpg_s600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Q_8yQZfGQWQAX-8-7OB&_nc_ht=scontent-los2-1.xx&oh=00_AfAmuwmML_o9XdhH4JaBT9gBCoNvyrDO1Be-bXayimV7SA&oe=64726791",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348478182_1884225118624349_2141292536707922522_n.jpg?stp=dst-jpg_s600x600&_nc_cat=108&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7rPO0AVKeEoAX9KkixZ&_nc_ht=scontent-los2-1.xx&oh=00_AfD8jc434rex5uARlsr6WgpHgchK1_ggV6XikS5K3J4m_g&oe=6471E820",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348301448_162329663265099_219385787481362787_n.jpg?stp=dst-jpg_s600x600&_nc_cat=108&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=OVY6ye_viJQAX9omvew&_nc_ht=scontent-los2-1.xx&oh=00_AfCTaQMSRl5PSiTKwm3De2wGrAAq9_jmLfJCExyYelrohQ&oe=647341E8",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new IBAYAT_AND_FASATIN()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348711035_931540521260821_7467829053531234706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=JH3TFfY0jX4AX9Dtyuo&_nc_ht=scontent-los2-1.xx&oh=00_AfAX9yLb-l3Fr2P82XZvYZDBcPMJyNuaGwEneCeUBcIvAQ&oe=6473DAE5",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348597882_811838663849275_6541443067414319706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=6Bbciii_E24AX9Trw_1&_nc_ht=scontent-los2-1.xx&oh=00_AfCVg0u2SRPEPtt4OHKB_g88RJs80FtlrWoWpP-DLqozjw&oe=64731E62",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348565135_284221830608711_150920686655546490_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3anKjHr64ysAX9puY2b&_nc_ht=scontent-los2-1.xx&oh=00_AfCz7Oy_l3NQ7mprOVfQGNb73urXCnyKypeEQV0aUkYgBg&oe=6471F83E",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new IBAYAT_AND_FASATIN()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348711035_931540521260821_7467829053531234706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=JH3TFfY0jX4AX9Dtyuo&_nc_ht=scontent-los2-1.xx&oh=00_AfAX9yLb-l3Fr2P82XZvYZDBcPMJyNuaGwEneCeUBcIvAQ&oe=6473DAE5",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348597882_811838663849275_6541443067414319706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=6Bbciii_E24AX9Trw_1&_nc_ht=scontent-los2-1.xx&oh=00_AfCVg0u2SRPEPtt4OHKB_g88RJs80FtlrWoWpP-DLqozjw&oe=64731E62",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348565135_284221830608711_150920686655546490_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3anKjHr64ysAX9puY2b&_nc_ht=scontent-los2-1.xx&oh=00_AfCz7Oy_l3NQ7mprOVfQGNb73urXCnyKypeEQV0aUkYgBg&oe=6471F83E",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new IBAYAT_AND_FASATIN()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348711035_931540521260821_7467829053531234706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=JH3TFfY0jX4AX9Dtyuo&_nc_ht=scontent-los2-1.xx&oh=00_AfAX9yLb-l3Fr2P82XZvYZDBcPMJyNuaGwEneCeUBcIvAQ&oe=6473DAE5",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348597882_811838663849275_6541443067414319706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=6Bbciii_E24AX9Trw_1&_nc_ht=scontent-los2-1.xx&oh=00_AfCVg0u2SRPEPtt4OHKB_g88RJs80FtlrWoWpP-DLqozjw&oe=64731E62",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348565135_284221830608711_150920686655546490_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3anKjHr64ysAX9puY2b&_nc_ht=scontent-los2-1.xx&oh=00_AfCz7Oy_l3NQ7mprOVfQGNb73urXCnyKypeEQV0aUkYgBg&oe=6471F83E",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new IBAYAT_AND_FASATIN()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348711035_931540521260821_7467829053531234706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=JH3TFfY0jX4AX9Dtyuo&_nc_ht=scontent-los2-1.xx&oh=00_AfAX9yLb-l3Fr2P82XZvYZDBcPMJyNuaGwEneCeUBcIvAQ&oe=6473DAE5",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348597882_811838663849275_6541443067414319706_n.jpg?stp=dst-jpg_s600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=6Bbciii_E24AX9Trw_1&_nc_ht=scontent-los2-1.xx&oh=00_AfCVg0u2SRPEPtt4OHKB_g88RJs80FtlrWoWpP-DLqozjw&oe=64731E62",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348565135_284221830608711_150920686655546490_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3anKjHr64ysAX9puY2b&_nc_ht=scontent-los2-1.xx&oh=00_AfCz7Oy_l3NQ7mprOVfQGNb73urXCnyKypeEQV0aUkYgBg&oe=6471F83E",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.ACCESSORIES.Any())
                {
                    context.ACCESSORIES.AddRange(new List<ACCESSORIE>()
                    {
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B"
                            ,Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new ACCESSORIE()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346632814_263946652718714_7060995510139386776_n.jpg?stp=dst-jpg_p480x480&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=gXItnRt5m_IAX-Qm_K5&_nc_ht=scontent-los2-1.xx&oh=00_AfDqBOmrJn1xkMd4RGvNwBW-GIyaRlBOO9K2Z4a8wlIbWg&oe=647318AE",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346617650_690676916196186_3866753439523654291_n.jpg?stp=dst-jpg_p480x480&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=PpgMFW-elSIAX8JFU4s&_nc_ht=scontent-los2-1.xx&oh=00_AfCbww2rndh_dRwPY_wW6PXYa1p_c60UwFRyjL1J0eweFw&oe=64722E04",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346610696_2059442831062033_2238241741875673862_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=dpw6cWq14vcAX8zE63F&_nc_ht=scontent-los2-1.xx&oh=00_AfCGtIZtn-GnFgndPwJ5LumVYUrG0s9jy4Oj-CtwgVDBtw&oe=6472CC0B",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Backses.Any())
                {
                    context.Backses.AddRange(new List<Backs>()
                    {
                        new Backs()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347285041_140104459052865_7340535715330366377_n.jpg?stp=dst-jpg_p480x480&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=s08HkOkjGDwAX936o7R&_nc_ht=scontent-los2-1.xx&oh=00_AfCXXwN_4pM8D2qzdQ0ZcW0IrWL933ZHgYGnWMVBrj6xkg&oe=6472664D",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347553222_699240131957235_2008032653857823064_n.jpg?stp=dst-jpg_p600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=TQvHQ6WSUcgAX8cebnQ&_nc_ht=scontent-los2-1.xx&oh=00_AfCpar6WWlKlO7nNF9cDBsDzY81XweT1_FFN7KtHq9hxsg&oe=6473247A",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347412426_1686675805124132_4010686597053682422_n.jpg?stp=dst-jpg_p600x600&_nc_cat=104&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qJ93g1w0miAAX_TiLcw&_nc_ht=scontent-los2-1.xx&oh=00_AfBMROjgF5f2mXak2V4_7F5gOJEpAPA5B_tRMNx-GBGfrg&oe=6473BDE9",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new Backs()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347285041_140104459052865_7340535715330366377_n.jpg?stp=dst-jpg_p480x480&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=s08HkOkjGDwAX936o7R&_nc_ht=scontent-los2-1.xx&oh=00_AfCXXwN_4pM8D2qzdQ0ZcW0IrWL933ZHgYGnWMVBrj6xkg&oe=6472664D",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347553222_699240131957235_2008032653857823064_n.jpg?stp=dst-jpg_p600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=TQvHQ6WSUcgAX8cebnQ&_nc_ht=scontent-los2-1.xx&oh=00_AfCpar6WWlKlO7nNF9cDBsDzY81XweT1_FFN7KtHq9hxsg&oe=6473247A",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347412426_1686675805124132_4010686597053682422_n.jpg?stp=dst-jpg_p600x600&_nc_cat=104&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qJ93g1w0miAAX_TiLcw&_nc_ht=scontent-los2-1.xx&oh=00_AfBMROjgF5f2mXak2V4_7F5gOJEpAPA5B_tRMNx-GBGfrg&oe=6473BDE9",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new Backs()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347285041_140104459052865_7340535715330366377_n.jpg?stp=dst-jpg_p480x480&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=s08HkOkjGDwAX936o7R&_nc_ht=scontent-los2-1.xx&oh=00_AfCXXwN_4pM8D2qzdQ0ZcW0IrWL933ZHgYGnWMVBrj6xkg&oe=6472664D",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347553222_699240131957235_2008032653857823064_n.jpg?stp=dst-jpg_p600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=TQvHQ6WSUcgAX8cebnQ&_nc_ht=scontent-los2-1.xx&oh=00_AfCpar6WWlKlO7nNF9cDBsDzY81XweT1_FFN7KtHq9hxsg&oe=6473247A",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347412426_1686675805124132_4010686597053682422_n.jpg?stp=dst-jpg_p600x600&_nc_cat=104&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qJ93g1w0miAAX_TiLcw&_nc_ht=scontent-los2-1.xx&oh=00_AfBMROjgF5f2mXak2V4_7F5gOJEpAPA5B_tRMNx-GBGfrg&oe=6473BDE9",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new Backs()
                        {
                           Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347285041_140104459052865_7340535715330366377_n.jpg?stp=dst-jpg_p480x480&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=s08HkOkjGDwAX936o7R&_nc_ht=scontent-los2-1.xx&oh=00_AfCXXwN_4pM8D2qzdQ0ZcW0IrWL933ZHgYGnWMVBrj6xkg&oe=6472664D",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347553222_699240131957235_2008032653857823064_n.jpg?stp=dst-jpg_p600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=TQvHQ6WSUcgAX8cebnQ&_nc_ht=scontent-los2-1.xx&oh=00_AfCpar6WWlKlO7nNF9cDBsDzY81XweT1_FFN7KtHq9hxsg&oe=6473247A",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347412426_1686675805124132_4010686597053682422_n.jpg?stp=dst-jpg_p600x600&_nc_cat=104&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qJ93g1w0miAAX_TiLcw&_nc_ht=scontent-los2-1.xx&oh=00_AfBMROjgF5f2mXak2V4_7F5gOJEpAPA5B_tRMNx-GBGfrg&oe=6473BDE9",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new Backs()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347285041_140104459052865_7340535715330366377_n.jpg?stp=dst-jpg_p480x480&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=s08HkOkjGDwAX936o7R&_nc_ht=scontent-los2-1.xx&oh=00_AfCXXwN_4pM8D2qzdQ0ZcW0IrWL933ZHgYGnWMVBrj6xkg&oe=6472664D",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347553222_699240131957235_2008032653857823064_n.jpg?stp=dst-jpg_p600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=TQvHQ6WSUcgAX8cebnQ&_nc_ht=scontent-los2-1.xx&oh=00_AfCpar6WWlKlO7nNF9cDBsDzY81XweT1_FFN7KtHq9hxsg&oe=6473247A",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347412426_1686675805124132_4010686597053682422_n.jpg?stp=dst-jpg_p600x600&_nc_cat=104&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qJ93g1w0miAAX_TiLcw&_nc_ht=scontent-los2-1.xx&oh=00_AfBMROjgF5f2mXak2V4_7F5gOJEpAPA5B_tRMNx-GBGfrg&oe=6473BDE9",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                        new Backs()
                        {
                            Name="اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347285041_140104459052865_7340535715330366377_n.jpg?stp=dst-jpg_p480x480&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=s08HkOkjGDwAX936o7R&_nc_ht=scontent-los2-1.xx&oh=00_AfCXXwN_4pM8D2qzdQ0ZcW0IrWL933ZHgYGnWMVBrj6xkg&oe=6472664D",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347553222_699240131957235_2008032653857823064_n.jpg?stp=dst-jpg_p600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=TQvHQ6WSUcgAX8cebnQ&_nc_ht=scontent-los2-1.xx&oh=00_AfCpar6WWlKlO7nNF9cDBsDzY81XweT1_FFN7KtHq9hxsg&oe=6473247A",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347412426_1686675805124132_4010686597053682422_n.jpg?stp=dst-jpg_p600x600&_nc_cat=104&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qJ93g1w0miAAX_TiLcw&_nc_ht=scontent-los2-1.xx&oh=00_AfBMROjgF5f2mXak2V4_7F5gOJEpAPA5B_tRMNx-GBGfrg&oe=6473BDE9",
                            Description="هذا هو وصف المنتج",
                            Sex="للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.BeautyProducts.Any())
                {
                    context.BeautyProducts.AddRange(new List<BeautyProduct>()
                    {

                        new BeautyProduct(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347100323_796125838520127_4674051258950668781_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=kdlajbdCkzQAX9OxmD3&_nc_ht=scontent-los2-1.xx&oh=00_AfCgK2VMcJJlaraZtuyO79OETNii-rehxvQ9KTfOZ9haMA&oe=64735A58",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346809487_194747746835648_6797500315702011322_n.jpg?stp=dst-jpg_p600x600&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=c9TUq1M87kgAX_FZ3-R&_nc_ht=scontent-los2-1.xx&oh=00_AfAzs2wIg1zJAeiRSEEsbQaiLcAYcO8OB2TMWyFZiYg-Qw&oe=64728D12",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347119346_995447631614952_6372963380922072840_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7srk3NWMOX0AX_MqUtx&_nc_ht=scontent-los2-1.xx&oh=00_AfAmQOI3HSRsBNskjJ0x6DPTUC59clvXSz5Uw7x4CxNyYw&oe=64733BD7",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new BeautyProduct(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347100323_796125838520127_4674051258950668781_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=kdlajbdCkzQAX9OxmD3&_nc_ht=scontent-los2-1.xx&oh=00_AfCgK2VMcJJlaraZtuyO79OETNii-rehxvQ9KTfOZ9haMA&oe=64735A58",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346809487_194747746835648_6797500315702011322_n.jpg?stp=dst-jpg_p600x600&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=c9TUq1M87kgAX_FZ3-R&_nc_ht=scontent-los2-1.xx&oh=00_AfAzs2wIg1zJAeiRSEEsbQaiLcAYcO8OB2TMWyFZiYg-Qw&oe=64728D12",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347119346_995447631614952_6372963380922072840_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7srk3NWMOX0AX_MqUtx&_nc_ht=scontent-los2-1.xx&oh=00_AfAmQOI3HSRsBNskjJ0x6DPTUC59clvXSz5Uw7x4CxNyYw&oe=64733BD7",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new BeautyProduct(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347100323_796125838520127_4674051258950668781_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=kdlajbdCkzQAX9OxmD3&_nc_ht=scontent-los2-1.xx&oh=00_AfCgK2VMcJJlaraZtuyO79OETNii-rehxvQ9KTfOZ9haMA&oe=64735A58",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346809487_194747746835648_6797500315702011322_n.jpg?stp=dst-jpg_p600x600&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=c9TUq1M87kgAX_FZ3-R&_nc_ht=scontent-los2-1.xx&oh=00_AfAzs2wIg1zJAeiRSEEsbQaiLcAYcO8OB2TMWyFZiYg-Qw&oe=64728D12",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347119346_995447631614952_6372963380922072840_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7srk3NWMOX0AX_MqUtx&_nc_ht=scontent-los2-1.xx&oh=00_AfAmQOI3HSRsBNskjJ0x6DPTUC59clvXSz5Uw7x4CxNyYw&oe=64733BD7",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new BeautyProduct(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347100323_796125838520127_4674051258950668781_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=kdlajbdCkzQAX9OxmD3&_nc_ht=scontent-los2-1.xx&oh=00_AfCgK2VMcJJlaraZtuyO79OETNii-rehxvQ9KTfOZ9haMA&oe=64735A58",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346809487_194747746835648_6797500315702011322_n.jpg?stp=dst-jpg_p600x600&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=c9TUq1M87kgAX_FZ3-R&_nc_ht=scontent-los2-1.xx&oh=00_AfAzs2wIg1zJAeiRSEEsbQaiLcAYcO8OB2TMWyFZiYg-Qw&oe=64728D12",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347119346_995447631614952_6372963380922072840_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7srk3NWMOX0AX_MqUtx&_nc_ht=scontent-los2-1.xx&oh=00_AfAmQOI3HSRsBNskjJ0x6DPTUC59clvXSz5Uw7x4CxNyYw&oe=64733BD7",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new BeautyProduct(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347100323_796125838520127_4674051258950668781_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=kdlajbdCkzQAX9OxmD3&_nc_ht=scontent-los2-1.xx&oh=00_AfCgK2VMcJJlaraZtuyO79OETNii-rehxvQ9KTfOZ9haMA&oe=64735A58",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346809487_194747746835648_6797500315702011322_n.jpg?stp=dst-jpg_p600x600&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=c9TUq1M87kgAX_FZ3-R&_nc_ht=scontent-los2-1.xx&oh=00_AfAzs2wIg1zJAeiRSEEsbQaiLcAYcO8OB2TMWyFZiYg-Qw&oe=64728D12",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347119346_995447631614952_6372963380922072840_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7srk3NWMOX0AX_MqUtx&_nc_ht=scontent-los2-1.xx&oh=00_AfAmQOI3HSRsBNskjJ0x6DPTUC59clvXSz5Uw7x4CxNyYw&oe=64733BD7",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new BeautyProduct(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347100323_796125838520127_4674051258950668781_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=kdlajbdCkzQAX9OxmD3&_nc_ht=scontent-los2-1.xx&oh=00_AfCgK2VMcJJlaraZtuyO79OETNii-rehxvQ9KTfOZ9haMA&oe=64735A58",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346809487_194747746835648_6797500315702011322_n.jpg?stp=dst-jpg_p600x600&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=c9TUq1M87kgAX_FZ3-R&_nc_ht=scontent-los2-1.xx&oh=00_AfAzs2wIg1zJAeiRSEEsbQaiLcAYcO8OB2TMWyFZiYg-Qw&oe=64728D12",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347119346_995447631614952_6372963380922072840_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=7srk3NWMOX0AX_MqUtx&_nc_ht=scontent-los2-1.xx&oh=00_AfAmQOI3HSRsBNskjJ0x6DPTUC59clvXSz5Uw7x4CxNyYw&oe=64733BD7",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Giftses.Any())
                {
                    context.Giftses.AddRange(new List<Gifts>()
                    {
                        new Gifts(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new Gifts(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new Gifts(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new Gifts(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new Gifts(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new Gifts(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new Gifts(){
                           Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346624350_230653532993131_6462174391376073728_n.jpg?stp=dst-jpg_p480x480&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=aTkamXrjqDoAX8WEXbm&_nc_ht=scontent-los2-1.xx&oh=00_AfAOl62UsfSb0FPcvtrEVTaUFcE_PkK0ZSYVqV2DGvIUtw&oe=6472E6A7",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346873707_1601403973674801_6824361186518364299_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=g4xa87QeLsgAX9Re7gu&_nc_ht=scontent-los2-1.xx&oh=00_AfCIFhtXx2YoaBdfcwlHhydURqSeJ0oDPcMoUXfVZkK2JQ&oe=6472E1EA",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/346629722_936222057695534_1026929676566537853_n.jpg?stp=dst-jpg_s600x600&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oVmp61j34r8AX9tfujK&_nc_ht=scontent-los2-1.xx&oh=00_AfDFuaQDhN9JwcF5cVJEUwCQrIMNaP-SZDlqMZ49VlyQ5g&oe=64739E7D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.HairCreams.Any())
                {
                    context.HairCreams.AddRange(new List<HairCream>()
                    {
                        new HairCream(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                             Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                             Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HairCream(){
                             Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/347108568_910392383581229_5774179012219192251_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=saUwnXO59IcAX-56JFe&_nc_ht=scontent-los2-1.xx&oh=00_AfBsjH_fxs5z6u5imwx6Vs2WeKOz82Ektp4PbvsXn0pN5w&oe=64734380",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/345672372_1022100738776076_7551672303148859022_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=p1WFZUozd-gAX8YfptK&_nc_ht=scontent-los2-1.xx&oh=00_AfDmMdqe_6MYXKu_w1CXYC01p115kw9XR_LzC9CTJJyDRw&oe=6472CD1D",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },

                    });
                    context.SaveChanges();
                }
                if (!context.HomeAccessorieses.Any())
                {
                    context.HomeAccessorieses.AddRange(new List<HomeAccessories>()
                    {
                        new HomeAccessories(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                           Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                           Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new HomeAccessories(){
                           Name = "اجمل عباية",
                            PhotoURL1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTP2xbwoGAVU-PJxHXOT6pJ_PSNaiblpv3ibg&usqp=CAU",
                            PhotoURL2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHFniixzYZjUkuueSFbgji50MoCtHSStlXVw&usqp=CAU",
                            PhotoURL3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReLOKRanS0390dNKfUnNKU3A1TFJPcBAxn5g&usqp=CAU",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.TIRAHS.Any())
                {
                    context.TIRAHS.AddRange(new List<TIRAH>()
                    {
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new TIRAH(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340907102_184721071082495_955044185445796571_n.jpg?stp=dst-jpg_s600x600&_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=D4hsZhGNw9gAX-ti2hw&_nc_ht=scontent-los2-1.xx&oh=00_AfD4JF3JVPzI75MFbIlIbZd8dI-5iw6o7-9JNaRzhE8oTA&oe=6473B519",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340748389_544268891085331_5886066904738155267_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=8-SoZZsYvYMAX8jfD3B&_nc_oc=AQm_J2GRoMLCbSM3qnEXHItO3d9rvPZveBdgd5jiD3-aYK6k8-2YEK94y-6I_YaWxzE&_nc_ht=scontent-los2-1.xx&oh=00_AfCUFdNR_PJsWNV_6idAQz3dFxZ2veqjpNlUMwgnRIxiPg&oe=6472A563",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/340745009_1261492618076680_6777342133032523367_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1ZMLBH0yQ9MAX_GRvQ7&_nc_ht=scontent-los2-1.xx&oh=00_AfAgHxHn75n1zm8QxaemaVpgi76Z0rF2hcGl1w3tmU2roA&oe=64731722",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.UnderWears.Any())
                {
                    context.UnderWears.AddRange(new List<UnderWear>()
                    {
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new UnderWear(){
                            Name = "اجمل عباية",
                            PhotoURL1 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348286298_3225886917708354_2251580328375952647_n.jpg?stp=dst-jpg_p417x417&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=e00hC3WOM5MAX_b4PMt&_nc_ht=scontent-los2-1.xx&oh=00_AfBScV4m5D8h52-K_RlP4wKMJoBpHEiNHK9-Tz2d4D214g&oe=64720874",
                            PhotoURL2 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348244359_260098346425443_1391653372187117184_n.jpg?stp=dst-jpg_p417x417&_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=S0L2F57FUCMAX8Imygg&_nc_ht=scontent-los2-1.xx&oh=00_AfBpMOFv8QBgupSiAzmuZY8RVg5mLmmZ4CN6QOR1MGIqkQ&oe=6472AAB1",
                            PhotoURL3 = "https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/348269154_115796994833471_2023545009492866320_n.jpg?stp=dst-jpg_p417x417&_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=oMp-ibkNHHkAX_CrJer&_nc_oc=AQmBTXsyqLGGV1Qv5PMs9iTLpG7OqrO1_69rP4CpvDVhPj8quFWebtRBCxYLMt4ZZfU&_nc_ht=scontent-los2-1.xx&oh=00_AfDwbx9hWASGvz-xqIkiGtsNqSmwz3cm0ZG2mm4RPmtpdQ&oe=647309E8",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.WomenShooeses.Any())
                {
                    context.WomenShooeses.AddRange(new List<WomenShooese>()
                    {
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                        new WomenShooese(){
                            Name = "اجمل عباية",
                            PhotoURL1="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344201053_6688594744485371_2095847035060792797_n.jpg?stp=dst-jpg_s600x600&_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=1GonfH5GnAkAX8M324p&_nc_ht=scontent-los2-1.xx&oh=00_AfBk2-QPeFxuu__3g84e_9tJFrHX8THaF_UWQsVASzX7NQ&oe=6472DE01",
                            PhotoURL2="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344909539_725797842561426_5912044096681355185_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=3a_MnsF4gZQAX9CbmFj&_nc_oc=AQmpMGDbhJMrpFHM4qjDH7KWSjYHHvqDrFpckHFsCR7VqGP7Zke9alyDqvAh5-2Iv4c&_nc_ht=scontent-los2-1.xx&oh=00_AfBvT9-zYktbNjLYQ6oSflVfMsaN8G0q9lZrKFtIVO0-pQ&oe=647366A0",
                            PhotoURL3="https://scontent-los2-1.xx.fbcdn.net/v/t39.30808-6/344858039_599384985464648_296044160852672251_n.jpg?stp=dst-jpg_s600x600&_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=Gcyon0f65ugAX_Lyejz&_nc_ht=scontent-los2-1.xx&oh=00_AfBBFpiYVvD1kn793gNkWvP1AsGikWf8NtkYnK1uKnpQkw&oe=647303EF",
                            Description = "هذا هو وصف المنتج",
                            Sex = "للرجال والنساء"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "admin@stchad.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        FullName = "Ali Achair Langaba",
                        UserName = "Ali Lanagab",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }
                string appUserEmail = "user@stchad.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
