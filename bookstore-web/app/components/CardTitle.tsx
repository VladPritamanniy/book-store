interface Props {
    title: string;
    price: number;
};

export const CardTitle = ({title, price}: Props) => {
    return (
        <div className="card-container">
            <p className="card-title">{title}</p>
            <p className="card-price">{price}</p>
        </div>
    )
};