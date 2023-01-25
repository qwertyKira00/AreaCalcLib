CREATE TABLE product (
    id INT PRIMARY KEY,
    productName VARCHAR(255),
    productDescription VARCHAR(255)
);

CREATE TABLE category (
    id INT PRIMARY KEY,
    categorytName VARCHAR(255),
    categoryDescription VARCHAR(255)
);

CREATE TABLE product_category (
    id INT PRIMARY KEY,
    productId INT,
    categoryId INT,
  	FOREIGN KEY (productId) REFERENCES product (id),
  	FOREIGN KEY (categoryId) REFERENCES category (id)
);

SELECT p.productName, c.categorytName
FROM product p LEFT JOIN product_category pc ON p.id = pc.productId 
LEFT JOIN category c ON c.id = pc.categoryId;