import React from "react";
import testImage from "./mks_fStDJan92023.jpg";
import "./Card.css";

// Prevents unassigned proper fields from being sent in as parameters to the Cards
interface Props {
  companyName: string;
  ticker: string;
  price: number;
}

// Type checking, "Props" in the alligator brackets "<>" make the ": Props" part redundant but can be left on. The return type is also declared as a JSX element
const Card: React.FC<Props> = ({
  companyName,
  ticker,
  price,
}: Props): JSX.Element => {
  return (
    <div className="card-container">
      <img src={testImage} alt="testImage" />
      <div className={companyName}>
        <h2>{ticker}</h2>
        <p>$$$${price}</p>
        <div className="info">
          Lorem ipsum dolor, sit amet consectetur adipisicing elit. Error
          praesentium temporibus laboriosam officia fuga beatae, magni excepturi
          ratione veniam hic dolorem, laudantium tenetur consequatur cupiditate
          veritatis blanditiis eligendi dolorum itaque.
        </div>
      </div>
    </div>
  );
};

export default Card;
