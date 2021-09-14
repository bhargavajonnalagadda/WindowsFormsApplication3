# WindowsFormsApplication3
Have followed the domain driven approach. Derived entities such as Driver ,TRip and a TripDriverReport.
defined the basic properties in the interface and implemented the interface in the class.
next tried to read the data, which is prefilled into the text box, the code written is generic, so the same method can be used to read the data from any input file.
trying to read differant commands and based on the paramters supplied with command , creating the corresponding object.
creating respective object is encapculated, there by , if there is any new task, we can modify the utilobjectcreator , to create a specific object for the passed command.
need not modify the end client, thus having less dependencies and not exposing the object creation methods.
have thought of using multiple constructors in the class to compute some preperties and save them at the time of creation the object.
once the object is created , updating a dictionary collection of drivers and their trips.
the collection is static, and if need can be stored into a data store.
once the commands are all created, then we will cimpute the result based on driver and trips and publish the results back to text box in the UI.
the classes have been designed using single reason for chnage, other than the entity driven properties and CRUD tasks, no other actions are allowed.
some of the actions were not impelmented as they were not needed at this point.
written test cases where we tested for one valid case and one invalid case, where the end string returned does not match.
