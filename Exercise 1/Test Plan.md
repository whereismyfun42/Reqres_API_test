This test plan is intended to verify the functional and non-functional requirements of the REST API documented in https://reqres.in/api-docs/. The API provides a set of endpoints to manage users and their associated resources. The testing will be performed by the Quality Assurance team, and the results will be documented and reported to the development team for remediation.

Scope:

The scope of this test plan includes functional and non-functional testing of the API endpoints listed in the documentation. The test cases will be written and executed to verify the API's compliance with the requirements, ensure proper error handling, and validate the response payloads.

Test Objectives:

The objectives of this test plan are to:

Verify that the API provides the expected Create, Read, Update, and Delete (CRUD) operations for records.
Ensure that the API returns the correct responses and error messages for each operation.
Verify that the API performs the expected operations on the database.
Ensure that the API handles concurrency and other edge cases correctly.


Test Environment:

The test environment will consist of the following components:

The REST API under test.
A testing tool that can make REST API requests, such as Postman or cURL.
A server environment capable of running the API under test.

Test Scenarios:

The following scenarios will be tested:

Creating a new record: Verify that the API can create a new record and returns the expected response.
Reading a record: Verify that the API can read an existing record and returns the expected response.
Updating a record: Verify that the API can update an existing record and returns the expected response.
Deleting a record: Verify that the API can delete an existing record and returns the expected response.
Invalid input handling: Verify that the API handles invalid input data correctly and returns the expected error message.
Concurrency handling: Verify that the API can handle multiple requests to modify the same record concurrently and returns the expected response.
Boundary cases: Verify that the API handles edge cases correctly, such as empty or null values, out-of-range values, and invalid data types.


Test Cases:

Test GET /{resource} endpoint:

Send a GET request to /{resource} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct number of records based on the "per_page" parameter
Send a GET request to an invalid resource (e.g. /invalid_resource)
Verify that the response status code is 404
Send a GET request to /{resource} endpoint with invalid parameters (e.g. /{resource}?page=-3 or /{resource}?page=-3&per_page=-10)
Verify that the response status code is 400
Verify that no private information is leaked through a bad request

Test POST /{resource} endpoint:

Send a POST request to /{resource} endpoint with valid data
Verify that the response status code is 405

Test PUT /{resource} endpoint:

Send a PUT request to /{resource} endpoint with valid data
Verify that the response status code is 405

Test PATCH /{resource} endpoint:

Send a PATCH request to /{resource} endpoint with valid data
Verify that the response status code is 405

Test DELETE /{resource} endpoint:

Send a DELETE request to /{resource} endpoint with a valid data
Verify that the response status code is 405

Test GET /users endpoint:

Send a GET request to /users endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct number of records based on the "per_page" parameter
Send a GET request to an invalid resource (e.g. /invalid_resource)
Verify that the response status code is 404
Send a GET request to /{resource} endpoint with invalid parameters (e.g. /users?page=-3 or /users?page=-3&per_page=kajsdh)
Verify that the response status code is 400
Verify that no private information is leaked through a bad request

Test POST /users endpoint:

Send a POST request to /users endpoint with valid data
Verify that the response status code is 405

Test PUT /users endpoint:

Send a PUT request to /users endpoint with valid data
Verify that the response status code is 405

Test PATCH /users endpoint:

Send a PATCH request to /users endpoint with valid data
Verify that the response status code is 405

Test DELETE /users endpoint:

Send a DELETE request to /users endpoint with a valid data
Verify that the response status code is 405

Test GET /{resource}/{id} endpoint:

Send a GET request to /{resource}/{id} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct data based on the id
Send a GET request to an invalid resource id (e.g. /{resource}/invalid_id)
Verify that the response status code is 404

Test POST /{resource}/{id} endpoint:

Send a POST request to /{resource}/{id} endpoint with valid data
Verify that the response status code is 405
Verify that the response contains all expected data fields and values for the newly created record
Send a POST request to a valid resource but invalid resource id (e.g. /{resource}/invalid_id)
Verify that the response status code is 405

Test DELETE /{resource}/{id} endpoint:

Send a DELETE request to /{resource}/{id} endpoint
Verify that the response status code is 204
Verify that the response contains all expected data fields and values (none)
Send a GET request to a deleted resource (e.g. /{resource}/invalid_id)
Verify that the response status code is 404

Test PUT /{resource}/{id} endpoint:

Send a PUT request to /{resource}/{id} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct data based on the id
Send a PUT request to an invalid resource id (e.g. /{resource}/invalid_id)
Verify that the response status code is 404

Test PATCH /{resource}/{id} endpoint:

Send a PATCH request to /{resource}/{id} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct data based on the id
Send a PATCH request to an invalid resource id (e.g. /{resource}/invalid_id)
Verify that the response status code is 404

Test GET /users/{id} endpoint:

Send a GET request to /users/{id} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct data based on the id
Send a GET request to an invalid user id (e.g. /users/invalid_id)
Verify that the response status code is 404

Test POST /users/{id} endpoint:

Send a POST request to /users/{id} endpoint with valid data
Verify that the response status code is 405
Verify that the response contains all expected data fields and values for the newly created record
Send a POST request to a valid resource but invalid users id (e.g. /users/invalid_id)
Verify that the response status code is 405

Test DELETE /users/{id} endpoint:

Send a DELETE request to /users/{id} endpoint
Verify that the response status code is 204
Verify that the response contains all expected data fields and values (none)
Send a GET request to a deleted user (e.g. /users/deleted_id)
Verify that the response status code is 404

Test PUT /users/{id} endpoint:

Send a PUT request to /users/{id} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct data based on the id
Send a PUT request to an invalid users id (e.g. /users/invalid_id)
Verify that the response status code is 404

Test PATCH /users/{id} endpoint:

Send a PATCH request to /users/{id} endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Verify that the response contains the correct data based on the id
Send a PATCH request to an invalid users id (e.g. /users/invalid_id)
Verify that the response status code is 404

Test POST /login endpoint:

Send a POST request to /login endpoint with valid data
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Send a POST request with invalid data (e.g. non-existent password or email)
Verify that the response status code is 400

Test POST /register endpoint:

Send a POST request to /register endpoint with valid data
Verify that the response status code is 200
Verify that the response contains all expected data fields and values
Send a POST request with invalid data (e.g. non-defined user)
Verify that the response status code is 400

Test POST /logout endpoint:

Send a POST request to /login endpoint
Verify that the response status code is 200
Verify that the response contains all expected data fields and values

Test GET /login endpoint:

Send a GET request to /login endpoint with valid data
Verify that the response status code is 405

Test PUT /login endpoint:

Send a PUT request to /login endpoint with valid data
Verify that the response status code is 405

Test DELETE /login endpoint:

Send a DELETE request to /login endpoint with valid data
Verify that the response status code is 405

Test PATCH /login endpoint:

Send a POST request to /login endpoint with valid data
Verify that the response status code is 405

Test GET /logout endpoint:

Send a GET request to /logout endpoint with valid data
Verify that the response status code is 405

Test PUT /logout endpoint:

Send a PUT request to /logout endpoint with valid data
Verify that the response status code is 405

Test DELETE /logout endpoint:

Send a DELETE request to /logout endpoint with valid data
Verify that the response status code is 405

Test PATCH /logout endpoint:

Send a POST request to /logout endpoint with valid data
Verify that the response status code is 405

Test GET /register endpoint:

Send a GET request to /register endpoint with valid data
Verify that the response status code is 405

Test PUT /register endpoint:

Send a PUT request to /logout endpoint with valid data
Verify that the response status code is 405

Test DELETE /register endpoint:

Send a DELETE request to /register endpoint with valid data
Verify that the response status code is 405

Test PATCH /register endpoint:

Send a POST request to /register endpoint with valid data
Verify that the response status code is 405

Test Data:

The following test data will be used during the testing process:

Valid input data for creating, updating, and reading records.
Invalid input data for testing error handling.
Existing records for testing updating and deleting operations.
Non-existent records for testing error handling.


Conclusion:

By following this test plan, we can ensure that the REST API provides the expected CRUD operations for records, returns the correct responses and error messages for each operation, and handles concurrency and edge cases correctly. This will help ensure the reliability and stability of the API, leading to a better user experience for the consumers of the API.