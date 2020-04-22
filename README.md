# corePoint
clone this REPO

# Back End Engineering Challenge -- Libera Drive

Libera-Drive is building a quick prototype for an Uber/Lift like system and needs a quick REST API to build out the prototype.  This API will focus on finding the 'street' closest to the input user coordinates.  
We will use (0,0) is the center, X is the horizontal, Y is the vertical.  
- Streets will be input as a beginning point and end point with a name
- User location will be a point in the system
- the API should be build to:
  - add a street with a name using 2 points (POST baseurl/street - with the body being a street)
  ```
  { 
    name: string
    start: [x,y]
    end: [x,y]
  }
  ```
  for example: 
  ```
  { 
    name: Main
    start: [0,0]
    end: [10,30.5]
  }
  ```

## Requirements
- Do not include a database (for this iteration store all your data 'in-memory')
- Create tests (either physically or suggest in your README) for any common issues
- Handle errors 

- develop your solution as a complete package that will be run by the Libera team
  - Include a readme and/or instructions for installing and running
  - Induced instructions on how to run your included test or what those tests are
  - Document any assumptions you made and issues you encountered.
  
  
  
## Running the Application
- Open this project with VS 2017+
- Port={your_dev_port}
- Open this URL: https://localhost:44339/swagger/index.html:
- run click F5
- Port={your_dev_port}

##step 1
- @inpout new data: Try
- /api/Location/AddLocation
- Json input data:
{
  "ItemName": "string",
  "x": 0,
  "y": 0,
  "x1": 0,
  "y1": 0,
  "Distance": 0
}
click execute.
#step 2
@get Locations: try
/api/Location/GetLocationItems
click execute
# repeat step 1 as many time as you want.
#calculate Distances (formula used Math.Sqrt(number) and a* = a for SQR only)
##assumptions
there is no distance point of reference eg:
5 miles from given point
you will see the closest one first.
you will be testing using swagger V1
##Enjoy


