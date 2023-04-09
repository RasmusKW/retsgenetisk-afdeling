using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Data")]
public class DataController : ControllerBase
{
    // List to store the blood data objects
    private static List<BloodData> bloodDataList = new List<BloodData>();

    [HttpGet]
    public IActionResult Get()
    {
        // Inserting mock data if the list is empty (Solely for the simplicity of populating some data, i would never do it here otherwise)
        if (bloodDataList.Count == 0)
        {
            bloodDataList.AddRange(new BloodData[]{
                new BloodData { ID = 15, PatientName = "Anders",  Date = "01/02/2022 ", Time = "16:00", BloodType = "O+", HBA1C = 3.3, BloodGlucose = 4.4, BloodInsulin = 90, BloodGlucagon = 40 },
                new BloodData { ID = 14, PatientName = "Anders",  Date = "01/05/2022", Time = "12:00",  BloodType = "O+", HBA1C = 3.7, BloodGlucose =  5.0, BloodInsulin = 120, BloodGlucagon = 50 },
                new BloodData { ID = 13, PatientName = "Anders",  Date = "01/08/2022", Time = "08:00",  BloodType = "O+", HBA1C = 3.5, BloodGlucose = 4.8, BloodInsulin = 100, BloodGlucagon = 45 },
                new BloodData { ID = 12, PatientName = "Kim",  Date = "06/02/2022", Time = "17:00",  BloodType = "A-", HBA1C = 3.8, BloodGlucose = 5.0, BloodInsulin = 120, BloodGlucagon = 50 },
                new BloodData { ID = 11, PatientName = "Kim",  Date = "06/05/2022", Time = "13:00", BloodType = "A-", HBA1C = 4.0, BloodGlucose = 5.2, BloodInsulin = 130, BloodGlucagon = 55 },
                new BloodData { ID = 10, PatientName = "Kim",  Date = "06/08/2022", Time = "09:00", BloodType = "A-", HBA1C = 3.9, BloodGlucose = 5.1, BloodInsulin = 125, BloodGlucagon = 52 },
                new BloodData { ID = 9, PatientName = "Mette",  Date = "07/03/2022", Time = "18:00",  BloodType = "AB-", HBA1C = 4.0, BloodGlucose = 4.3, BloodInsulin = 135, BloodGlucagon = 60 },
                new BloodData { ID = 8, PatientName = "Mette",  Date = "07/06/2022", Time = "14:00",  BloodType = "AB-", HBA1C = 4.2, BloodGlucose = 4.5, BloodInsulin = 145, BloodGlucagon = 65 },
                new BloodData { ID = 7, PatientName = "Mette",  Date = "07/09/2022", Time = "10:00", BloodType = "AB-", HBA1C = 4.1, BloodGlucose = 4.4, BloodInsulin = 140, BloodGlucagon = 62 },
                new BloodData { ID = 6, PatientName = "Per",  Date = "03/04/2022", Time = "07:00", BloodType = "B+", HBA1C = 4.2, BloodGlucose = 5.0, BloodInsulin = 150, BloodGlucagon = 70 },
                new BloodData { ID = 5, PatientName = "Per",  Date = "03/07/2022", Time = "11:00",  BloodType = "B+", HBA1C = 4.4, BloodGlucose = 5.2, BloodInsulin = 160, BloodGlucagon = 75 },
                new BloodData { ID = 4, PatientName = "Per",  Date = "03/10/2022", Time = "15:00",  BloodType = "B+", HBA1C = 4.3, BloodGlucose = 5.1, BloodInsulin = 155, BloodGlucagon = 72 },
                new BloodData { ID = 3, PatientName = "Rasmus",  Date = "13/02/2022", Time = "19:00",  BloodType = "A+", HBA1C = 8.8, BloodGlucose = 15.6, BloodInsulin = 900, BloodGlucagon = 150 },
                new BloodData { ID = 2, PatientName = "Rasmus",  Date = "13/05/2022", Time = "15:00",  BloodType = "A+", HBA1C = 9.5, BloodGlucose = 18.2, BloodInsulin = 1000, BloodGlucagon = 170 },
                new BloodData { ID = 1, PatientName = "Rasmus",  Date = "13/08/2022", Time = "11:00",  BloodType = "A+", HBA1C = 10.1, BloodGlucose = 10.1, BloodInsulin = 1100, BloodGlucagon = 190 },
            });
        }

         Response.Headers.Add("Access-Control-Allow-Origin", "*");

        return Ok(bloodDataList);
    }
}

