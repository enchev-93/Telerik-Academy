/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/


function solve() {
	var library = (function () {
		var books = [],
			categories = [],
			args;

		function isNumber(n) {
			return !isNaN(parseFloat(n)) && isFinite(n);
		}

		function listBooks() {
			args = arguments[0];

			if (books.length === 0) {
				return [];
			}

			if (books.length === 1) {
				if (!args || books[0].category === args.category) {
					return books;
				}

				return [];
			}

			if (args) {
				books = books.filter(function(b) {
					return b.category === args.category;
				});
			}

			return books.sort(function(a, b) {
				return a.ID - b.ID;
			});
		}

		function addBook(book) {

			function checkForRepeatingISBN(existingBook) {
				if (books.length === 0) {
					return false;
				}

				return existingBook.isbn === book.isbn;
			}

			function checkForRepeatingTitle(existingBook) {
				if (books.length === 0) {
					return false;
				}

				return existingBook.title === book.title;
			}

			if (books.some(checkForRepeatingTitle)) {
				throw new Error('Adding a book title that already exists is not allowed.');
			}

			if (books.some(checkForRepeatingISBN)) {
				throw new Error('Adding a book ISBN that already exists is not allowed.');
			}

			if (!book.category) {
				book.category = '';
			}

			if (book.title && (book.title.length < 2 || book.title.length > 100)) {
				throw new Error('Book title must be between 2 and 100 characters.');
			}

			if (!book.author) {
				throw new Error('Author must be a non-empty string.');
			}

			if (!(book.isbn.length === 10 || book.isbn.length === 13)) {
				throw new Error('Book ISBN must be either 10 or 13 digits.');
			}

			if (!isNumber(book.isbn)) {
				throw new Error('Book ISBN must be a number.');
			}

			book.ID = books.length + 1;
			books.push(book);

			var newCategory = {
				category: book.category,
				ID: categories.length + 1
			};

			if (categories.length === 0) {
				categories.push(newCategory);
			} else if (categories && !categories.some(function(element) {
					return element.category === newCategory.category;
				})) {
				categories.push(newCategory);
			}

			return book;
		}

		function listCategories() {
			categories.sort(function(a, b) {
				return a.ID - b.ID;
			});

			return categories.map(function(element) {
				return element.category;
			})
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());

	return library;
}
module.exports = solve;
