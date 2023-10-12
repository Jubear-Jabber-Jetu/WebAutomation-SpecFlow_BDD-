Feature: Search with long query
@mytest_7
	Scenario: Check if the search bar can handle a long query
		Given Have to go to the Base page
		When In search bar search for NVDIA geForce RTX 3080 and 32 GB ram
		Then See does any product appears or not