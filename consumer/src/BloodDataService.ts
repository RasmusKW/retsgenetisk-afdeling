const BASE_URL = "http://localhost:5212/data";
// Function retrieving data from the webservice specified by the URL. 
export async function getData() {
    const response = await fetch(`${BASE_URL}`);
    const data = await response.json(); // conv. data to JSON format
    return data;
}