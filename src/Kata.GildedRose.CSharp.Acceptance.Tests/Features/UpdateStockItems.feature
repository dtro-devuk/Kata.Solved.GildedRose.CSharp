Feature: Update Stock Inventory
	As an inn keeper
	I want the system to automatically update item quality and sell by dates
	So that I can keep track of stock items

Scenario: Quality reduces each day
	Given an item with quality of 10
	And an item with a sell in of 10 
	And an item with the name "+5 Dexterity Vest"
	When the system updates the stock inventory
	Then the item should have a quality of 9

#Scenario: Sell by date reduces each day
#	Given an item with a sell in of 10
#	And an item with the name "+5 Dexterity Vest"
#	When the system updates the stock inventory
#	Then the item should have a sell in of 9

#Scenario: Quality degrades twice as fast once the sell by date has passed 
#	Given an item with a sell in of 0 
#	And an item with quality of 10
#	And an item with the name "+5 Dexterity Vest"
#	When the system updates the stock inventory
#	Then the item should have a quality of 8
#
#Scenario: Quality of an item is never negative
#	Given an item with a sell in of 0 and a quality of 0
#	And an item with the name "+5 Dexterity Vest"
#	When the system updates the stock inventory
#	Then the item should have a quality of 0
#	
#Scenario: Aged Brie increases in quality the older it gets
#	Given an item with quality of 10
#	And an item with a sell in of 10 
#	And an item with the name "Aged Brie" 
#	When the system updates the stock inventory
#	Then the item should have a quality of 11
#
#Scenario: Quality of an item is never more than 50
#	Given an item with the name "Aged Brie" 
#	And an item with quality of 50
#	When the system updates the stock inventory
#	Then the item should have a quality of 50
#
#Scenario: Legendary items never decrease in quality
#	Given an item with the name "Sulfuras, Hand of Ragnaros" 
#	And an item with quality of 50
#	When the system updates the stock inventory
#	Then the item should have a quality of 50
#	
#Scenario Outline: Quality of a listed item is never more than 50
#	Given an item with the name "<name>" 
#	And an item with quality of <quality>
#	And an item with a sell in of <sellin> 
#	When the system updates the stock inventory
#	Then the item should have a quality less than or equal to 50
#Examples: 
#| name                       | quality | sellin |
#| +5 Dexterity Vest          | 50      | 10     | 
#| Aged Brie                  | 50      | 20     | 
#| Sulfuras, Hand of Ragnaros | 50      | 30     |
# 
# Scenario Outline: Quality of a listed item is never negative
#	Given an item with the name "<name>" 
#	And an item with quality of <quality>
#	And an item with a sell in of <sellin> 
#	When the system updates the stock inventory
#	Then the item should never have a quality equal a negative value -1
#Examples: 
#| name                       | quality | sellin |
#| +5 Dexterity Vest          | 0       | 0      |
#| Aged Brie                  | 0       | 0      |
#| Sulfuras, Hand of Ragnaros | 0       | 0      |
#
#Scenario: Legendary items never need to be sold
#	Given an item with the name "Sulfuras, Hand of Ragnaros" 
#	And an item with a sell in of 10
#	When the system updates the stock inventory
#	Then the item should have a sell in of 10
#	
##Scenario: Backstage passes increase in quality each day when the concert date is far away
##	Given an item with the name "Backstage passes to a TAFKAL80ETC concert"
##	And an item with quality of 10
##	And an item with a sell in of 20
##	When the system updates the stock inventory
##
##Scenario: Backstage passes increase in quality twice as fast when then concert date is nearer
##	Given an item with the name "Backstage passes to a TAFKAL80ETC concert"
##	And an item with quality of 10
##	And an item with a sell in of 10
##	When the system updates the stock inventory
##	Then the item should have a quality of 12
##
##Scenario: Backstage passes increase in quality three time as fast when the concert is very near
##	Given an item with the name "Backstage passes to a TAFKAL80ETC concert"
##	And an item with quality of 10 
##	And an item with a sell in of 5
##	When the system updates the stock inventory
##	Then the item should have a quality of 13
#
##Above 3 tests Refactored
#
#Scenario Outline: Backstage passes increase in quality at quicker rates when the concert date approaches
#	Given an item with the name "Backstage passes to a TAFKAL80ETC concert"
#	And an item with quality of <quality>
#	And an item with a sell in of <sellin> 
#	When the system updates the stock inventory
#	Then the item should have a quality of <value>
#Examples: 
#| quality | sellin | value |
#| 10      | 20     | 11    |
#| 10      | 10     | 12    |
#| 10      | 5      | 13    |
#
#Scenario: Backstage passes have no value after a concert
#	Given an item with the name "Backstage passes to a TAFKAL80ETC concert"
#	And an item with quality of 10
#	And an item with a sell in of 0
#	When the system updates the stock inventory
#	Then the item should have a quality of 0
#
##Scenario: Conjured items degrade in quality twice as fast
##	Given an item with the name "Conjured water"
##	And an item with quality of 10 
##	And an item with a sell in of 10
##	When the system updates the stock inventory
##	Then the item should have a quality of 8
