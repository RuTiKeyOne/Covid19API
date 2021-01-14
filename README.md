# Covid19 API
This API deserializes data obtained using the postman.

How you can use this API, I will write down below.

You can get information with Reception class 

# Summary
### A summary of new and total cases per country updated daily.

![alt text](https://i.ibb.co/8rb3s9v/2021-01-13-174246.png)

![alt text](https://i.ibb.co/sstsTj8/image.png)

# Countries
### Returns all the available countries and provinces, as well as the country slug for per country requests.

![alt text](https://i.ibb.co/qJHxqvN/image.png)

![alt text](https://i.ibb.co/PYtCh4p/image.png)

# Day One
### Returns all cases by case type for a country from the first recorded case. Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/1GwBQ4Q/image.png)

![alt text](https://i.ibb.co/PQJbY22/image.png)

# Day One All Status
### Returns all cases by case type for a country from the first recorded case. Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/QD0MKgk/image.png)

![alt text](https://i.ibb.co/2spCJ4Y/image.png)

# Day One Live
### Returns all cases by case type for a country from the first recorded case with the latest record being the live count. Country must be the Slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/5WkKNTt/image.png)

![alt text](https://i.ibb.co/qF27VR6/image.png)

# Day One Total
### Returns all cases by case type for a country from the first recorded case. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/JHRnYsB/image.png)

![alt text](https://i.ibb.co/89dJ2Gb/image.png)

# Day One Total All Status
### Returns all cases by case type for a country from the first recorded case. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/SmmYGDM/image.png)

![alt text](https://i.ibb.co/JtQv9JC/image.png)

# By Country
### Returns all cases by case type for a country. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/7gfY1mG/2021-01-13-225030.png)

![alt text](https://i.ibb.co/B44XKxh/image.png)

# By Country All Status
### Returns all cases by case type for a country. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/bHwP5DC/image.png)

![alt text](https://i.ibb.co/x8tq8b4/image.png)

# By Country Live

![alt text](https://i.ibb.co/8rXz9f6/image.png)

![alt text](https://i.ibb.co/gy0FqG7/image.png)

# By Country Total
### Returns all cases by case type for a country. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/QPw4PcQ/image.png)

![alt text](https://i.ibb.co/0FKNmCP/image.png)

# By Country Total All Status
### Returns all cases by case type for a country. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/bdDKMwZ/image.png)

![alt text](https://i.ibb.co/hfLWtJg/image.png)

# Live By Country And Status
### Returns all live cases by case type for a country. These records are pulled every 10 minutes and are ungrouped. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

![alt text](https://i.ibb.co/3WrbydD/image.png)

![alt text](https://i.ibb.co/s66KVJQ/image.png)

# Live By Country All Status
### Returns all live cases by case type for a country. These records are pulled every 10 minutes and are ungrouped. Country must be the slug from /countries or /summary. Cases must be one of: confirmed, recovered, deaths

