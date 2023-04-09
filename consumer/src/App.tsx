import React, { useState } from 'react';
import { getData } from './BloodDataService';
import { BloodData } from './BloodDataType';

function App() {
  // Initializing state variable "data" w. empty array and "setData" function to update it's state.
  const [data, setData] = useState<BloodData[]>([]);

  //retrieving data and setting the data 
  async function handleGetData() {
    const newData = await getData();
    setData(newData);
  }  

  return (
    <div className="flex flex-col">
      <h6 className="mb-4 pt-6 pb-2 text-center text-4xl leading-tight">Rasmus Wedelheim - Assignment for Retsgenetisk Afdeling</h6>
      <h4 className="text-2xl border-b text-center font-medium leading-tight">Blood data</h4>
      {/* Button to fetch the data */}
      <button type="button" onClick={handleGetData}
        className="inline-block w:30 rounded hover:bg-info bg-primary px-6 pb-2 pt-2.5 text-xs font-medium uppercase leading-normal text-white">
        Click to Fetch Data
      </button>

      {/* Table for data */}
      <div className="overflow-x-auto sm:-mx-6 lg:-mx-8">
        <div className="inline-block min-w-full py-2 sm:px-6 lg:px-8">
          <div className="overflow-hidden">
            <table className="min-w-full text-left text-sm font-light">

              {/* Table Header */}
              <thead className="border-b font-medium dark:border-neutral-500">
                <tr>
                  <th scope="col" className="px-6 py-4">#</th>
                  <th scope="col" className="px-6 py-4">Patient Name</th>
                  <th scope="col" className="px-6 py-4">Date</th>
                  <th scope="col" className="px-6 py-4">Time</th>
                  <th scope="col" className="px-6 py-4">Blood Type</th>
                  <th scope="col" className="px-6 py-4">HbA1c (Hemoglobin) | %</th>
                  <th scope="col" className="px-6 py-4">Blood Glucose | mmol/L</th>
                  <th scope="col" className="px-6 py-4">Blood Insulin | pmol/L</th>
                  <th scope="col" className="px-6 py-4">Blood Glucagon | pmol/L</th>
                </tr>
              </thead>

              {/* Table Body */}
              <tbody>
                {/* Using Map to get each element from the data array */}
                {data.map(item => (
                  <tr className="border-b hover:bg-neutral-100 dark:border-neutral-500" key={item.id}>
                    <td className="whitespace-nowrap px-6 py-4">{item.id}</td>
                    <td className="whitespace-nowrap px-6 py-4">{item.patientName}</td>
                    <td className="whitespace-nowrap px-6 py-4">{item.date}</td>
                    <td className="whitespace-nowrap px-6 py-4">{item.time}</td>
                    <td className="whitespace-nowrap px-6 py-4">{item.bloodType}</td>
                    <td className={`whitespace-nowrap px-6 py-4 ${item.hbA1C > 6.5 ? 'font-bold' : ''}`}>{item.hbA1C}</td>
                    <td className={`whitespace-nowrap px-6 py-4 ${item.bloodGlucose > 7.0 ? 'font-bold' : ''}`}>{item.bloodGlucose}</td>
                    <td className={`whitespace-nowrap px-6 py-4 ${item.bloodInsulin > 250 ? 'font-bold' : ''}`}>{item.bloodInsulin}</td>
                    <td className={`whitespace-nowrap px-6 py-4 ${item.bloodGlucagon > 149 ? 'font-bold' : ''}`}>{item.bloodGlucagon}</td>
                  </tr>
                ))}
              </tbody>

            </table>
          </div>
        </div>
      </div>
    </div>

  );
}

export default App;