# Nop.Plugin.Packaging.Boxes
Config files for my GitHub profile.

This project is to achieve the calculation done for the courier boxes required for the order placed on nopCommerce

Example: The store owner will define the no of boxes in the admin area and the boxes product category, that which box belongs to which category of product.

On each order placement this plugin will calculate the no of boxes required for that particular order as per the width, length and depth of the box and the same variables define for the products.

for this purpose this plugin development has been break into the following.

1. Define Plugin
2. Create custom tables in the database for the following task
 * Boxes (boxes will be define in this table)
 * OrderBoxes (this table save the no of boxes qty for each order in rows)
3. Create Admin Area Menu For The Following Pages
 * Add Box (Insert Box)
 * Manage Boxes (List Box / Delete / Edit)
 * Boxes Order List (this will have the quantity of boxes required for each order)
