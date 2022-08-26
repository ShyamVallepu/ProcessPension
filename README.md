##  Process Pension Service
* It takes in the pensioner detail like the name, aadhaar number
* Verifies if the pensioner detail is accurate by getting the data from PensionerDetail Microservice or not. 
* If not, validation message `“Invalid pensioner detail provided, please provide valid detail.”`
* If valid, then pension calculation is done and the Process Pension Output  is returned to the Web application to be displayed on the UI.


1. Open your Visual Studio and run the service.
2. Open your browser and head to this URL - https://localhost:44394/swagger/index.html this will redirect you to Swagger UI where you can test the service.
3. **Get Pension Details functionality**
Select **/pensionerInput** POST method and click try it out
**Valid Input**

```
{
  "aadhaarNumber": "123456789012",
}
```

{
    "message": "POST Request successful.",
    "result": {
        "pensionAmount": 25550,
        "bankCharge": 550
    }
}

**Invalid Input**

```
{
  "aadhaarNumber": "123456789012",
  }
  
  ** Response **
  
 { 
 "title": "Not Found",
 "status": 404,
 }
 
