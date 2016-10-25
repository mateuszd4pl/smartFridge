SELECT *
FROM productsInFridge
INNER JOIN allProducts
ON productsInFridge.Barcode=allProducts.Barcode
WHERE allProducts.Name='japko';