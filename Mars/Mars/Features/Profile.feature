Feature: Profile

As a seller 
I want to add my profile details
So that people seeking for some skills can look into my details

@tag1
Scenario Outline: Add my Language details into profile page
	Given I logged into Mars page and navigate to profile page successfully
	When I add my '<Language>','<Level>' to the profile page
	Then I able to see '<Language>','<Level>' in the profile page

	Examples: 
	| Language   | Level	|
	| Sinhala    | Fluent	|
	| English    | Fluent	|


Scenario Outline: Add my Skills into Profile page
	Given I logged into Mars page and navigate to profile page successfully
	When I add '<Skill>','<Level>' to the profile page
	Then I able to see '<Skill>','<Level>' in my profile page 

	Examples: 
	| Skill			| Level        |
	| Leadership    | Intermediate |
	| Communication | Expert       |

Scenario Outline: Add my Education details into profile page
	Given I logged into Mars page and navigate to profile page successfully
	When I add my '<University>','<Country>','<Title>','<Degree>','<GraduationYear>'to the profile page
	Then I able to see '<University>','<ountry>','<Title>','<Degree>','<Graduation Year>' in the profile page

	Examples:
	| University | Country	| Title  | Degree       | GraduationYear |
	| Peradeniya | Sri Lanka| M.Tech | Food Science | 2007           |
	| Peradeniya | Sri Lanka| B.Sc   | Agriculture  | 2002           |

Scenario Outline: Add my Certifications into profile page
	Given I logged into Mars page and navigate to profile page successfully
	When I add my'<Certificate>','<From>','<Year>' to the profile page
	Then I able to see my Certifications in the profile page

	Examples: 
	| Certificate | From      | Year |
	| SQL         | w3schools | 2022 |
	| C#          | w3schools | 2023 |
	

Scenario: Add my Description into profile page
	Given I logged into Mars page and navigate to profile page successfully
	When I add my Desription to the profile page
	Then I able to see the details in the description





	 