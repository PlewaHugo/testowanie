import Button from "@/components/Button";
import Container from "@/components/Container";
import Heading from "@/components/Heading";
import Navbar from "@/components/Navbar";
import Paragraph from "@/components/Paragraph";
import { useState } from "react";

export default function Clicker() {
  
  const [x,setX]=useState(0)
  
  return <Container>
            <Heading level={1} content="Poklikaj mnie"/>
            <Paragraph content={`Kliknięto ${x} raz(y)`}/>
            <Button onClick={()=>setX(x+1)} text="Kliknij mnie"></Button>
        </Container>;
}