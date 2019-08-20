# Travel API

#### _API for reviewing travel destinations, 8/20/2019_

#### _By **Trevor Teigen & Marqis Ramos**_

## Description

This application is meant to explore building an API to be interacted with later. THe API will store reviews and destinations in a local database and allows values to be added, edited, or removed.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Controller that allows the creation of destinations** | "Disneyland" | Disneyland page with basic information and a list of reviews |
| Users shoud be able to see/create pages for the various destinations they have been to. |
| **Controller that allows the creation of reviews** | Phillis wrote: "Disneyland was great! 10/10" | *under Disneyland* "Phillis' review, Average Rating 10/10" |
| Users can create reviews associated with the various places they have been |
| **Functionality for reviews to be linked to destinations** | "Disneyland rating 10/10" | Review created, Disneyland's AvgRating = 10+other reviews/number of all reviews for Disneyland |
|User's need to be able to search a destination and see all reviews associated to the destination, plus a summary of the destination's overall rating.|
| **Controller to edit reviews** | Change rating from "4" to "6" | _db.Entry(review).State = EntityState.Modified |
|This controller updates the database with the modified (new) information and recalculates the destination's rating|
| **Controller to delete reviews** | DELETE this review | _db.Reviews.Remove(thisReview) |
|This controller takes the review Id and removes the entire review from the database, it also then recalculates the destination's rating| 



## Setup/Installation Requirements

* Clone this repository and >dotnet run in terminal
* Navigate through the website through the links

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#


## Support and contact details

_Please contact Trevor Teigen with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Trevor Teigen_**