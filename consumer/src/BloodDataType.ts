// Interface which aligns with the object in the backend
export interface BloodData {
    id: number;
    patientName: string | null;
    date: string | null;
    time: string | null;
    bloodType: string | null;
    hbA1C: number;
    bloodGlucose: number;
    bloodInsulin: number;
    bloodGlucagon: number;
  }
  