#Parking Lot

Given a parking lot and a car
When park the car to the parking lot
Then will be able to pick the car from the parking lot

Given the parking lot is full
When park a car to the parking lot
Then will fail to park the car

Given the parking lot is full
When pick a car from the parking lot
Then will be able to park a car to the parking lot

Given picked a car parked in the parking lot
When pick the same car from the parking lot
Then will fail to pick the car

Given a parking lot
When pick a not-parked car from the parking lot
Then will fail to pick the car

Given a parking lot is not full
When park two cars
Then will be able to pick the two cars


#Parking Boy

Given a parking boy and a parking lot
When the parking boy park the car to a parking lot
Should be able to pick the same car from the parking lot

Given a parking boy and a parking lot
When the parking boy park the car
Should be able to pick the same car by the parking boy

Given a parking boy and two parking lots
When the parking boy park the car
Should be able to pick the same car from the first parking lot

Given a parking boy and two parking lots with first parking lot full
When the parking boy park the car
Should be able to pick the same car from the second parking lot

Given a parking boy and two parking lots with first parking lot full
When the parking boy park the car
Should be able to pick the same car by the parking boy

Given a parking boy and two full parking lots
When the parking boy park the car
Should fail to park the car

#Smart parking boy

Given a smart parking boy and a parking lot
When the smart parking boy park the car to a parking lot
Should be able to pick the same car from the parking lot

Given a smart parking boy and a parking lot
When the smart parking boy park the car
Should be able to pick the same car by the parking boy

Given a smart parking boy and two parking lots
When the smart parking boy park the car
Should be able to pick the same car from the first parking lot

Given a smart parking boy and two parking lots with first parking lot full
When the smart parking boy park the car
Should be able to pick the same car from the second parking lot

Given a smart parking boy and two parking lots with first parking lot full
When the smart parking boy park the car
Should be able to pick the same car by the parking boy

Given a smart parking boy and two full parking lots
When the smart parking boy park the car
Should fail to park the car

Given a smart parking boy and two parking lot(A with 1 empty lot and B with 2 empty lots)
When the smart parking boy park the car
Should be able to pick the car from B

Given a smart parking boy and two parking lot(A with 2 empty lot and B with 1 empty lots)
When the smart parking boy park the car
Should be able to pick the car from A

#Super parking boy

Given a super parking boy and parking lots
When the super parking boy park the car
Should act as a parking boy for super parking boy

Given a super parking boy and two parking lot(A with low vacancy rate and B with high vacancy rate)
When the super parking boy park the car
Should be able to pick the car from B

Given a super parking boy and two parking lot(A with high vacancy rate and B with low vacancy reate)
When the super parking boy park the car
Should be able to pick the car from A

#Parking mangager

Given a parking manager and a parking lot
When the parking manager park the car
Should be able to pick the car from the parking lot

Given a parking manager and a parking boy
When the parking manager park the car
Should be able to pick the car by the parking boy

Given a parking manager and a parking lot
When the parking manager park the car
Should be able to pick the car by the parking manager

Given a parking manager and a parking boy
When the parking manager park the car
Should be able to pick the car by the parking manager

