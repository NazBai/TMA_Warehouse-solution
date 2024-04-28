using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Security.Policy;

namespace TMA
{
    public class DataManager
    {
        public ListView requestRowData;
        public ListView requestData;
        public ListView itemData;
        public ListBox itemNames { set; get; }
        private static readonly HttpClient client = new HttpClient();

        public DataManager(ListView itemData, ListView requestData, ListView requestRowData)
        {
            this.itemData = itemData;
            this.requestRowData = requestRowData;
            this.requestData = requestData;
        }

        public async Task GetItemsDataAsync()
        {
            string result = "";
            string apiUrl = "http://localhost:5033/api/Item";

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                result = result.Substring(2, result.Length - 4);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }

            FillDataManagerTable(itemData, result);

        }
        public async Task GetRequestRowAsync(string rowId)
        {
            string result = "";
            string apiUrl = "http://localhost:5033/api/RequestRow/RequestRow/" + rowId;

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                result = result.Substring(2, result.Length - 4);

            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }

            FillDataManagerTable(requestRowData, result);

        }

        public async Task GetRequestDataManagerAsync()
        {
            string result = "";

            string apiUrl = "http://localhost:5033/api/Request";

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                result = result.Substring(2, result.Length - 4);

            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }

            FillDataManagerTable(requestData, result);

        }

        private void FillDataManagerTable(ListView listView, string data)
        {
            

            if (data == null || data == "")
            {
                return;
            }
            listView.Items.Clear();
            string[] splitedItemsJson = data.Split('{');
            string[] pairs;
            string[] singeItemInfo;
            foreach (string item in splitedItemsJson)
            {
                pairs = item.Split(',');
                singeItemInfo = new string[pairs.Length];
                for (int i = 0; i < singeItemInfo.Length; i++)
                {
                    if (pairs[i] != "")
                        singeItemInfo[i] = pairs[i].Split(':')[1].Trim('"', '}', ',');
                }
                ListViewItem listViewItem = new ListViewItem(singeItemInfo);
                listView.Items.Add(listViewItem);

            }

        }

        public async Task SendPutItemRequestAsync(string itemId, string name, string itemGroup,
                                                        string unitOfMesurment, string quantity, string price,
                                                        string status, string storageLocation, string contactPerson)
        {
            
            

            string url = "http://localhost:5033/api/Item";
            string jsonContent = "{\r\n  \"item_ID\": " + itemId +
                    ",\r\n  \"name\": \"" + name +
                    "\",\r\n  \"item_Group\": \"" + itemGroup +
                    "\",\r\n  \"unit_of_measurement\": \"" + unitOfMesurment +
                    "\",\r\n  \"quantity\": " + quantity +
                    ",\r\n  \"price_without_VAT\": " + price +
                    ",\r\n  \"status\": \"" + status +
                    "\",\r\n  \"storage_location\": \"" + storageLocation +
                    "\",\r\n  \"contact_person\": \"" + contactPerson + "\"\r\n}";
            try
            {
                string requestUrl = $"{url}/{itemId}";

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(requestUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("PUT request successful.");
                    MessageBox.Show("Item Updated");
                    _ = GetItemsDataAsync();
                }
                else
                {  
                    Console.WriteLine("Failed to send PUT request. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public async Task SendPutRequestRequestAsync(string requestId, string name, string comment,
                                                        string status)
        {
            string url = "http://localhost:5033/api/Request";
            string jsonContent ="{\"request_ID\": \"" + requestId + 
                "\",\"employee_name\": \""+ name +
                "\",\"comment\": \"" + comment +
                "\",\"status\": \"" + status +  "\"}";
            try
            {
                string requestUrl = $"{url}/{requestId}";

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(requestUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Request updated");
                    Console.WriteLine("PUT request successful.");
                    _ = GetRequestDataManagerAsync();
                }
                else
                {

                    Console.WriteLine("Failed to send PUT request. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public async Task SendPostRequestRequestAsync(string name, string comment,
                                                        string status, string itemName, string unitOfMeasurement, string quantity, string price)
        {
            string requestUrl = "http://localhost:5033/api/Request";
            string highestID = (GetCurrentRequestID() + 1) + "";
            string itemID = GetItemIdByName(itemName);
            string jsonRequestContent = "{\"request_ID\": \"" + 1 +
                "\",\"employee_name\": \"" + name +
                "\",\"comment\": \"" + " " +
                "\",\"status\": \"" + status + "\"}";

            try
            {

                var content = new StringContent(jsonRequestContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("PUT request successful.");
                    _ = SendPostRequestRowRequestAsync(highestID, comment, itemName, unitOfMeasurement, quantity, price);
                    MessageBox.Show("Request created");
                    _ = GetRequestDataManagerAsync();

                }
                else
                {

                    Console.WriteLine("Failed to send PUT request. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public async Task SendPostRequestRowRequestAsync(string requestId, string comment,
                                                        string itemName, string unitOfMeasurement, string quantity, string price)
        {
            string requestRowUrl = "http://localhost:5033/api/RequestRow";
            string itemID = GetItemIdByName(itemName);

            string jsonRequestRowContent = "{\"request_Row_ID\": 1," +
                "\r\n  \"request_ID\": " + requestId +
                ",\r\n  \"item_ID\": " + itemID +
                ",\r\n  \"unit_of_measurement\": \"" + unitOfMeasurement +
                "\",\r\n  \"quantity\": " + quantity +
                ",\r\n  \"price_without_VAT\": " + price +
                ",\r\n  \"comment\": \"" + comment + "\"\r\n}";
            Console.WriteLine(jsonRequestRowContent);
            try
            {

                var content = new StringContent(jsonRequestRowContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(requestRowUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    
                    Console.WriteLine("PUT request successful.");
                    MessageBox.Show("RequestRow created");

                }
                else
                {

                    Console.WriteLine("Failed to send PUT request. Status code: " + response.StatusCode);
                    MessageBox.Show("Failed to insert request row");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public async Task SendPostItemRequestAsync(string name, string itemGroup,
                                                        string unitOfMesurment, string quantity, string price,
                                                        string status, string storageLocation, string contactPerson)
        {

            try
            {
                string jsonDataManager = "{\r\n  \"item_ID\": " + 1 +
                    ",\r\n  \"name\": \"" + name +
                    "\",\r\n  \"item_Group\": \"" + itemGroup +
                    "\",\r\n  \"unit_of_measurement\": \"" + unitOfMesurment +
                    "\",\r\n  \"quantity\": " + quantity +
                    ",\r\n  \"price_without_VAT\": " + price +
                    ",\r\n  \"status\": \"" + status +
                    "\",\r\n  \"storage_location\": \"" + storageLocation +
                    "\",\r\n  \"contact_person\": \"" + contactPerson + "\"\r\n}";

                var content = new StringContent(jsonDataManager, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("http://localhost:5033/api/Item", content);


                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Record created successfully.");
                    MessageBox.Show("Item record Created");
                    _ = GetItemsDataAsync();
                }
                else
                {
                    MessageBox.Show("Error", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Failed to create record. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public async Task SendDeleteItemRequestAsync(string itemId)
        {
            string url = "http://localhost:5033/api/Item";
            try
            {
                string requestUrl = $"{url}/{itemId}";

                HttpResponseMessage response = await client.DeleteAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("DELETE request successful.");
                    MessageBox.Show("Item deleted");
                    _ = GetItemsDataAsync();
                }
                else
                {
                    Console.WriteLine("Failed to send DELETE request. Status code: " + response.StatusCode);
                    MessageBox.Show("Failed to delete item");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public void LoadItemNames()
        {
            List<string> namesList = new List<string>();

           

            foreach (ListViewItem item in itemData.Items)
            {
                namesList.Add(item.SubItems[1].Text);
            }

            itemNames.Items.AddRange(namesList.ToArray());
        }

        private int GetCurrentRequestID()
        {
            int columnIndex = 0;
            int maxIntValue = 0;

            if (requestData.Items.Count > 0)
            {
                 maxIntValue = requestData.Items
                                            .Cast<ListViewItem>()
                                            .Select(item => int.TryParse(item.SubItems[columnIndex].Text, out int value) ? value : 0)
                                            .Max();
            }
            else
            {
                MessageBox.Show("ListView is empty.");
            }

            return maxIntValue;
        }

        private string GetItemIdByName(string itemName)
        {
            string res = "";
            string targetValue = itemName;

            foreach (ListViewItem item in itemData.Items)
            {
                if (item.SubItems.Count > 1 && item.SubItems[1].Text == targetValue)
                {
                    res = item.SubItems[0].Text;

                    break;
                }
            }
            return res;


        }

        public string GetQuantityByName(string itemName)
        {
            string res = "";
            string targetValue = itemName;

            foreach (ListViewItem item in itemData.Items)
            {
               
                if (item.SubItems.Count > 1 && item.SubItems[1].Text == targetValue)
                {
                    res = item.SubItems[4].Text;

                    break;
                }
            }
            return res;


        }


        public void ReduseItemsQuantiry()
        {
            foreach (ListViewItem row in requestRowData.Items)
            {
                string itemId = row.SubItems[2].Text;

                foreach (ListViewItem item in itemData.Items)
                {
                    if (itemId == item.SubItems[0].Text)
                    {
                        int.TryParse(item.SubItems[4].Text, out int oldQuantity);
                        int.TryParse(row.SubItems[4].Text, out int rowQuantity);
                        string newQuantity = (oldQuantity - rowQuantity) + "";
                        _ = SendPutItemRequestAsync(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text,
                                           newQuantity, item.SubItems[5].Text, item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text);
                    }
                }
            }
        }
    

        public async Task SendDeleteRequestRequestAsync(string requestId)
        {
            string url = "http://localhost:5033/api/Request";
            try
            {
                string requestUrl = $"{url}/{requestId}";

                HttpResponseMessage response = await client.DeleteAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("DELETE request successful.");
                    _ = GetRequestDataManagerAsync();
                }
                else
                {
                    Console.WriteLine("Failed to send DELETE request. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}
