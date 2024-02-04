import './container.scss'

interface ContainerProps{
  children:JSX.Element|JSX.Element[]
}

export default function Container(props:ContainerProps) {
  return (
    <div className='container'>
      {props.children}
    </div>
  )
}