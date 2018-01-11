using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;

namespace TestProjectAndersen.DAL.EF
{
    class MetricsInitializer: DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var metrics = new List<Metric>
            {
                new Metric
                {
                    Name = "Refill Meds as appropriate",
                    Frequency = FrequencyType.Quarterly,
                },
                new Metric
                {
                    Name = "Daily prenatal vitamins",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Drug Abuse",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Diet",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Exercise Program",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Medication Compliance",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Smoking Status",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Flu Vaccine",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Pneumonia Vaccine",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Next Sched OB Appt",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Next Sched MD Appt",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Last Sched OB Appt",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Next Sched OB Appt",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Labs as directed by MD",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Blood Pressure (systolic)",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Blood Pressure (diastolic)",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Height (inches)",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Weight",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "BMI",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Total Cholesterol",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "LDL",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "HDL",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Lipid profile",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Triglycerides",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Continine level",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Allergies",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Chest Xray",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Echocardiogram",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "MicroAlbumin",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Daily weights  if ordered",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "GFR",
                    Frequency = FrequencyType.Semiannual
                },
                new Metric
                {
                    Name = "A1C",
                    Frequency = FrequencyType.Semiannual
                },
                new Metric
                {
                    Name = "Echocardiogram as directed",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "EKG",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "FBS daily testing",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "ABO Group and Rh type",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Antibody Screen",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "CBC",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Pap Smear",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Rubella Screen",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Varicella Screen",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "RPR/VDRL",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "GC/Chlamydia screen",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Sickle Cell",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Fetal aneuploidy Screen",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Fetal Ultrasounds",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "GTT (glucose tolerance test)",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Rh Antibody Status",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Group Beta Strep Culture",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "RhoGam (if necessary)",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "Delivery of health newborn",
                    Frequency = FrequencyType.Single
                },
                new Metric
                {
                    Name = "FBS",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "BMI",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Waist Circumference",
                    Frequency = FrequencyType.Semiannual
                },
                new Metric
                {
                    Name = "Oxygen usage",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Peak flow meter (If applicable)",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Asthma action plan",
                    Frequency = FrequencyType.Semiannual
                },
                new Metric
                {
                    Name = "Spirometry",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "FEV1",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Aspirin Therapy",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "Visual Foot Inspection",
                    Frequency = FrequencyType.Quarterly
                },
                new Metric
                {
                    Name = "MD foot exam",
                    Frequency = FrequencyType.Annual
                },
                new Metric
                {
                    Name = "Retinal Eye Exam",
                    Frequency = FrequencyType.Annual
                }
            };
            context.Metrics.AddRange(metrics);
            base.Seed(context);
        }
    }
}
