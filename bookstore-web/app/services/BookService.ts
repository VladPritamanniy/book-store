export interface BookRequest {
    title: string;
    description: string;
    price: number;
};

export const getAllBooks = async () => {
    const response = await fetch("https://localhost:7080/Books");
    return response.json();
};

export const createBooks = async (bookRequest : BookRequest) => {
    await fetch("https://localhost:7080/Books", {
        method: "POST",
        headers: {
            "content-type": "application/json"
        },
        body: JSON.stringify(bookRequest),
    });
};

export const updateBook = async (id: string, bookRequest : BookRequest) => {
    await fetch('https://localhost:7080/Books/' + id, {
        method: "PUT",
        headers: {
            "content-type": "application/json"
        },
        body: JSON.stringify(bookRequest),
    });
};

export const deleteBook = async (id: string) => {
    await fetch('https://localhost:7080/Books/' + id, {
        method: "DELETE"
    });
};