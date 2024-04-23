import React from "react";
import Card from "../Card";

type Props = {};

const CardList: React.FC<Props> = (props: Props): JSX.Element => {
  return (
    <div>
      <Card companyName="SEGA" ticker="SEGA" price={100} />
      <Card companyName="SEGA" ticker="SEGA" price={100} />
      <Card companyName="SEGA" ticker="SEGA" price={100} />
    </div>
  );
};

export default CardList;
