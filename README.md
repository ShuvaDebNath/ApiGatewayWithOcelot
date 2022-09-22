In this project, we know how to implement an API Gateway using Ocelot in MICROSERVICE project.

# Oelot
In Ocelot has a lot more features. but i used few of them. For better knowledge please go and read the documentation: https://ocelot.readthedocs.io/en/latest/

# UpstreamPathTemplate 
It defines the URL of the API Gateway that receives the requests and then redirects to the microservice API (DownstreamPathTemplate).

# UpstreamHttpMethod 
It defines the HTTP Methods (Get, Put, Post, Patch …) that the API Gateway uses to distinguish between the requests.

# DownstreamPathTemplate 
It represents the endpoint at the microservice that is going to receive the request. In other words, it takes the request of the UpstreamPathTemplate and redirects to the DownstreamPathTemplate.

# DownstreamScheme 
It represents the protocol to communicate with the microservice. 

# DownstreamHostAndPorts
It defines the URL and the port from the microservices that are going to receive the requests.

# RateLimitOptions
In this section, we have Period, PeriodTimespan, Limit. Once a request more than 3 times within 10 seconds, the API Gateway is going to return a Too Many Request (HTTP status 429). 

# TtlSeconds 
It stand for TIME TO LEAVE IN SECOND. It means, while the data is in the cache, the API Gateway doesn’t make an HTTP request to our microservice. That means we are saving resources from our microservice. Once the cache expires, the API Gateway requests the microservice once more and saves the data in the cache again.
