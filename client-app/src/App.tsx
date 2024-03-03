import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [members, setMembers] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5001/api/members')
      .then(response => {
        setMembers(response.data)
      })
  }, [])


  return (
    <div>
      <Header as='h2' icon='users' content='Gym Center'/>
      <List>
        {members.map((member: any) => (
          <List.Item key={member.id}>
            {member.firstName}
          </List.Item>
        ))}
      </List>
    </div>

  )
}

export default App
